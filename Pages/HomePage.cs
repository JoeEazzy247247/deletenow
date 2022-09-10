using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;

namespace deletenow.Pages
{
    public class HomePage
    {
        //BrowserDriver browserInteractions;
        //Or
        private IBrowserInteractions browserInteractions;
        private string url => "http://demoqa.com";
        public HomePage(IBrowserInteractions browserInteractions)
        {
            this.browserInteractions = browserInteractions;
        }

        private IWebElement Elements => 
            browserInteractions.WaitAndReturnElement(
                By.XPath("//div[@class='card mt-4 top-card'][.='Elements']"));

        public void GotoSite() => browserInteractions.GoToUrl(url);
        public void ClickElement() => Elements.ClickWithRetry();
    }
}
