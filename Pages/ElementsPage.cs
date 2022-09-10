using OpenQA.Selenium;
using SpecFlow.Actions.Selenium;


namespace deletenow.Pages
{
    public class ElementsPage
    {
        private readonly IBrowserInteractions browserInteractions;

        public ElementsPage(IBrowserInteractions browserInteractions)
        {
            this.browserInteractions = browserInteractions;
        }

        private IWebElement headertxt => 
            browserInteractions.WaitAndReturnElement(By.ClassName("main-header"));

        public string GetHeaderTxt() => headertxt.Text;
        public string GetHeaderTxt2()
        {
            return browserInteractions.WaitUntil(() =>
            headertxt.Text, result => !string.IsNullOrEmpty(result));
        }
            
    }
}
