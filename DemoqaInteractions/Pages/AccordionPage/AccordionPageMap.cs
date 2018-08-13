using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.AccordionPage
{
    public partial class AccordionPage
    {
        public IWebElement CustomizeIconsTab => Driver.FindElement(By.XPath("//*[@id=\"ui-id-2\"]"));

        public IWebElement ToggleIconsButton => Driver.FindElement(By.Id("toggle"));

        public IWebElement SectionFour => Driver.FindElement(By.XPath("//*[@id=\"ui-id-18\"]"));
    }
}
