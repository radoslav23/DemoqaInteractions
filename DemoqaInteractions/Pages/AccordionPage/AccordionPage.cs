using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.AccordionPage
{
    public partial class AccordionPage : BasePage
    {
        public AccordionPage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/accordion/";
        }

        public void GoToCustomizeIconsTab()
        {
            CustomizeIconsTab.Click();
        }

        public void ClickingToggleIconsButton()
        {
            ToggleIconsButton.Click();
        }
    }
}
