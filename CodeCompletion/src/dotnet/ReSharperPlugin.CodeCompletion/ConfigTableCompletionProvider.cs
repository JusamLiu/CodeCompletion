using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.DocumentModel;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.CodeCompletion;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.LookupItems.Impl;
using JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.Match;
using JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure;
using JetBrains.ReSharper.Feature.Services.Lookup;
using JetBrains.ReSharper.Features.Intellisense.CodeCompletion.CSharp.Rules;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.CSharp.Util.Literals;
using JetBrains.ReSharper.Psi.Resources;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.TextControl;
using JetBrains.UI.Icons;
using JetBrains.UI.RichText;

namespace ReSharperPlugin.MyAwesomePlugin;

[Language(typeof(CSharpLanguage))]
public class ConfigTableCompletionProvider : CSharpItemsProviderBase<CSharpCodeCompletionContext>
{
    protected override bool IsAvailable(CSharpCodeCompletionContext context)
    {
        return context.BasicContext.CodeCompletionType == CodeCompletionType.BasicCompletion;
    }

    protected override bool AddLookupItems(CSharpCodeCompletionContext context, IItemsCollector collector)
    {
        var ranges = context.CompletionRanges;
        IEnumerable<(string,string)> completionItems = null;
        if (IsSpecificArgumentInSpecificMethod(context, out var argumentLiteral, IsLoadSceneMethod,
                IsCorrespondingArgument("column")))
        {
            var cache = context.NodeInFile.GetSolution().GetComponent<ConfigTableCache>();
            completionItems = cache.GetAllPossibleSceneNames();
        } 
        
        
        var any = false;

        if (argumentLiteral != null)
        {
            var offset = argumentLiteral.GetDocumentRange().EndOffset;
            ranges = ranges.WithInsertRange(ranges.InsertRange.SetEndTo(offset)).WithReplaceRange(ranges.ReplaceRange.SetEndTo(offset));
        }

        if (completionItems != null)
        {
            foreach (var sceneName in completionItems)
            {
                any = true;
                var item = new StringLiteralItem($"\"{sceneName.Item1}\"",sceneName.Item2);
                item.InitializeRanges(ranges, context.BasicContext);
                collector.Add(item);
            }
        }

        return any;
    }


    private Func<IArgumentList, ICSharpArgument, bool> IsCorrespondingArgument(string argumentName)
    {
        return (argumentList, argument) => argument.IsNamedArgument && argument.NameIdentifier.Name.Equals(argumentName) ||
                                           !argument.IsNamedArgument && argumentList.Arguments[0] == argument;
    }
    
    private bool IsSpecificArgumentInSpecificMethod(CSharpCodeCompletionContext context,
        out ICSharpLiteralExpression stringLiteral,
        Func<IInvocationExpression, bool> methodChecker, Func<IArgumentList, ICSharpArgument, bool> argumentChecker)
    {
        stringLiteral = null;
        var nodeInFile = context.NodeInFile as ITokenNode;
        if (nodeInFile == null)
            return false;

        var possibleInvocationExpression = nodeInFile.Parent;
        if (possibleInvocationExpression is ICSharpLiteralExpression literalExpression)
        {
            if (!literalExpression.Literal.IsAnyStringLiteral())
                return false;

            var argument = CSharpArgumentNavigator.GetByValue(literalExpression);
            var argumentList = ArgumentListNavigator.GetByArgument(argument);
            if (argument == null || argumentList == null)
                return false;

            if (argumentChecker(argumentList, argument))
            {
                stringLiteral = literalExpression;
                possibleInvocationExpression = InvocationExpressionNavigator.GetByArgument(argument);
            }
        }

        if (possibleInvocationExpression is IInvocationExpression invocationExpression)
        {
            if (methodChecker(invocationExpression))
            {
                return true;
            }
        }

        stringLiteral = null;
        return false;
    }
    
    
    private bool IsLoadSceneMethod(IInvocationExpression invocationExpression)
    {
        return invocationExpression.InvocationExpressionReference.IsSceneManagerSceneRelatedMethod();
    }
    
    
    
    private sealed class StringLiteralItem : TextLookupItemBase
    {
        private readonly string _desc;
        public StringLiteralItem([NotNull] string text,string desc)
        {
            Text = text;
            _desc = desc;
        }


        public override RichText DisplayTypeName => new($"{_desc}");
        

        public override IconId Image => PsiSymbolsThemedIcons.Const.Id;

        public override MatchingResult Match(PrefixMatcher prefixMatcher)
        {
            var matchingResult = prefixMatcher.Match(Text);
            if (matchingResult == null)
                return null;
            return new MatchingResult(matchingResult.MatchedIndices, matchingResult.AdjustedScore - 100, matchingResult.OriginalScore);
        }

        public override void Accept(
            ITextControl textControl, DocumentRange nameRange, LookupItemInsertType insertType,
            Suffix suffix, ISolution solution, bool keepCaretStill)
        {
            base.Accept(textControl, nameRange, LookupItemInsertType.Replace, suffix, solution, keepCaretStill);
        }
    }
    
}