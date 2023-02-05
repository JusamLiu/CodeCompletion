using System.Threading;
using ConfigManager;
using JetBrains.Application.BuildScript.Application.Zones;
using JetBrains.ReSharper.Feature.Services;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.TestFramework;
using JetBrains.TestFramework;
using JetBrains.TestFramework.Application.Zones;
using NUnit.Framework;

[assembly: Apartment(ApartmentState.STA)]

namespace ReSharperPlugin.CodeCompletion.Tests
{
    [ZoneDefinition]
    public class CodeCompletionTestEnvironmentZone : ITestsEnvZone, IRequire<PsiFeatureTestZone>, IRequire<ICodeCompletionZone> { }

    [ZoneMarker]
    public class ZoneMarker : IRequire<ICodeEditingZone>, IRequire<ILanguageCSharpZone>, IRequire<CodeCompletionTestEnvironmentZone> { }

    [SetUpFixture]
    public class CodeCompletionTestsAssembly : ExtensionTestEnvironmentAssembly<CodeCompletionTestEnvironmentZone> { }


    public class A
    {
        public void ss()
        {
            Table t = new Table();
        }
        
    }
}
