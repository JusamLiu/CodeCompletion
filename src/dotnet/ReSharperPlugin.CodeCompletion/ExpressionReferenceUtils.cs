using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Tree;

namespace ReSharperPlugin.MyAwesomePlugin;

public static class ExpressionReferenceUtils
{
    public static bool IsSceneManagerSceneRelatedMethod(this IInvocationExpressionReference reference)
    {
        return IsRelatedMethod(reference, IsEditorSceneManagerLoadScene);
    }

    private static bool IsRelatedMethod(IInvocationExpressionReference reference, Func<IMethod, bool> checker)
    {
        var result = reference.Resolve();
        if (checker(result.DeclaredElement as IMethod))
            return true;

        foreach (var candidate in result.Result.Candidates)
        {
            if (checker(candidate as IMethod))
                return true;
        }

        return false;
    }

    private static bool IsEditorSceneManagerLoadScene(IMethod method)
    {
        if (method != null && CheckMethodName(method) &&
            method.GetContainingType()?.GetClrName().Equals(KnownTypes.ConfigTable) == true)
        {
            return true;
        }

        return false;
    }


    private static bool CheckMethodName(IMethod method)
    {
        var name = method.ShortName;
        return name.Equals("Get")
               || name.Equals("GetValueArrayInt32ByColumnValue")
               || name.Equals("GetArrayByNoneKey")
               || name.Equals("GetColumn")
               || name.Equals("GetInt")
               || name.Equals("GetFloat")
               || name.Equals("GetInt")
               || name.Equals("GetString");
    }
}