using AutoFixture;
using BoDi;
using deletenow.Pages;
using NUnit.Framework;
using SpecFlow.Actions.Selenium;
using System.Net.Mail;

namespace deletenow.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly HomePage homePage;
        private readonly ElementsPage elementsPage;
        public CalculatorStepDefinitions(IObjectContainer container)
        {
            homePage = container.Resolve<HomePage>();
            elementsPage = container.Resolve<ElementsPage>();
        }

        [Given(@"I am on site")]
        public void GivenIAmOnSite()
        {
            homePage.GotoSite();
        }

        [When(@"I click Elements")]
        public void WhenIClickElements()
        {
            homePage.ClickElement();
        }

        [Then(@"I am on Elements page")]
        public void ThenIAmOnElementsPage()
        {
            //elementsPage.GetHeaderTxt2();
            //Console.WriteLine(elementsPage.GetHeaderTxt2());
            //TestContext.Out.WriteLine(elementsPage.GetHeaderTxt2());
        }

        [Given(@"I have domain name as (.* email)")]
        public void GivenIHaveDomainNameAsAbcAbc_Com(string email)
        {
            Console.WriteLine(email);
        }  
    }
}
