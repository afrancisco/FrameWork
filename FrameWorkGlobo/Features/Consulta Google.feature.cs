﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FrameWorkGlobo.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Consulta Google", SourceFile="Features\\Consulta Google.feature", SourceLine=3)]
    public partial class ConsultaGoogleFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Consulta Google.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt"), "Consulta Google", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Pesquisar por SpecFlow no Google", new string[] {
                "chrome"}, SourceLine=6)]
        public virtual void PesquisarPorSpecFlowNoGoogle()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pesquisar por SpecFlow no Google", null, new string[] {
                        "chrome"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("que estou na pagina do Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 9
 testRunner.When("realizo uma pesquisa por SpecFlow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 10
 testRunner.Then("visualizo o site do SpecFlow no resultado da busca", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void VariasPesquisarNoGoogle(string busca, string textoDoLinkDoResultado, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "chrome"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Varias pesquisar no Google", null, @__tags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
 testRunner.Given("que estou na pagina do Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 15
 testRunner.When(string.Format("realizo uma pesquisa por SpecFlow {0}", busca), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 16
 testRunner.Then(string.Format("visualizo o site do SpecFlow no resultado da busca {0}", textoDoLinkDoResultado), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Varias pesquisar no Google, \"SpecFlow\"", new string[] {
                "chrome"}, SourceLine=19)]
        public virtual void VariasPesquisarNoGoogle_SpecFlow()
        {
#line 13
this.VariasPesquisarNoGoogle("\"SpecFlow\"", "\"SpecFlow - Binding Business Requirements to .NET Code\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Varias pesquisar no Google, \"Github\"", new string[] {
                "chrome"}, SourceLine=19)]
        public virtual void VariasPesquisarNoGoogle_Github()
        {
#line 13
this.VariasPesquisarNoGoogle("\"Github\"", "\"GitHub\"", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
