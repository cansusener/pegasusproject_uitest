// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDD.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute(TestName="Pegasus")]
    [NUnit.Framework.DescriptionAttribute("\t Bu dosya Pegasus senaryoları içerir.")]
    public partial class PegasusFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Pegasus.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("tr-TR"), "Pegasus", "\t Bu dosya Pegasus senaryoları içerir.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestCaseAttribute(TestName="Pegasus Bilet")]
        [NUnit.Framework.DescriptionAttribute("Pegasus Bilet")]
        [NUnit.Framework.CategoryAttribute("Pegasus")]
        public virtual void PegasusBilet()
        {
            string[] tagsOfScenario = new string[] {
                    "Pegasus"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pegasus Bilet", null, new string[] {
                        "Pegasus"});
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.And("\'#nxm2CookieSubmitButton\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 9
 testRunner.And("\'.nxm2_select-nereden  .select2-selection--single\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 10
    testRunner.And("\'.select2-search__field\' objesine \'Ankara\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 11
    testRunner.And("\'1\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 12
    testRunner.And("\'.nxm2_select-nereye  .select2-selection--single\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 13
    testRunner.And("\'.select2-search__field\' objesine \'İstanbul Tümü\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 14
    testRunner.And("\'#dp1\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 19
 testRunner.And("\'Gidiş Bilet\' seçimi \'31.Temmuz.2020\' yapılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 20
 testRunner.And("\'4\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 21
 testRunner.And("\'#dp2\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 22
 testRunner.And("\'Dönüş Bileti\' seçimi \'31.Ağustos.2020\' yapılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 23
 testRunner.And("\'#fligth-searh > div.row.search_flight-datepicker-container > div:nth-child(4) > " +
                        "div > button\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 24
 testRunner.And("\'4\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 29
 testRunner.And("\'.departure-list .availability-list-item-content\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 30
 testRunner.And("\'1\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 31
 testRunner.And("\'.departure-list .package-detail\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 32
 testRunner.And("\'1\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 33
 testRunner.And("\'.return-list .availability-list-item-content\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 34
 testRunner.And("\'1\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 35
 testRunner.And("\'.return-list .package-detail\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 36
 testRunner.And("\'.submit-button .button-text\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 37
 testRunner.And("\'.bundle-upgrade-modal-continue\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 41
 testRunner.And("\'.passenger-info-form .name .text-input input\' objesine \'CANSU\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 42
 testRunner.And("\'.passenger-info-form .surname .text-input input\' objesine \'ŞENER\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 44
 testRunner.And("\'.passenger-birthday-wrapper .date-text-input div input\' objesine \'20\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 45
 testRunner.And("\'.passenger-birthday-wrapper .date-text-input div ~div input\' objesine \'07\' yazıl" +
                        "ır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 46
 testRunner.And("\'.passenger-birthday-wrapper .date-text-input div ~div ~div input\' objesine \'1996" +
                        "\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 49
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[3]/div[2]/div[1]/div/div/form/div/di" +
                        "v/div/div[5]/div[1]/div/div[3]/div[1]/div/input\' alanına \'555\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 50
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[3]/div[2]/div[1]/div/div/form/div/di" +
                        "v/div/div[5]/div[1]/div/div[3]/div[2]/div/input\' alanına \'5555555\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 52
 testRunner.And("\'.field-wrapper .gender div input\' objesine tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 53
 testRunner.And("\'.field-wrapper .gender div input\' seçimi \'Kadın\' yapılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 55
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[3]/div[2]/div[1]/div/div/form/div/di" +
                        "v/div/div[6]/div/div[2]/div/div/input\' alanına \'11111111111\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 56
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[3]/div[2]/div[4]/button/div\' alanına" +
                        " tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 57
 testRunner.And("\'1\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 59
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[2]/div[2]/div/form/div/div[2]" +
                        "/div[4]/div/div/input\' alanına \'cansusener18@gmail.com\' yazılır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 62
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[2]/div[4]/button/div\' alanına" +
                        " tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 63
 testRunner.And("\'4\' saniye beklenir.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 64
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[4]/div[4]/button/div\' " +
                        "alanına tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 65
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[4]/div[4]/button/div\' " +
                        "alanına tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 66
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[3]/div[3]/button/div\' " +
                        "alanına tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 67
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[3]/div[3]/button/div\' " +
                        "alanına tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 68
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[3]/div[3]/button/div\' " +
                        "alanına tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 69
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[3]/div[3]/button/div\' " +
                        "alanına tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 70
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[5]/button/div\' alanına" +
                        " tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 71
 testRunner.And("\'/html/body/div[2]/div/div[4]/div[2]/div/div[2]/div[5]/div[3]/button/div\' alanına" +
                        " tıklanır.", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion