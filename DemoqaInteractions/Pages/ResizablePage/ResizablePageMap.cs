using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.ResizablePage
{
    public partial class ResizablePage
    {
        public IWebElement TabMinMax => Wait.Until(x => x.FindElement(By.Id("ui-id-5")));

        public IWebElement MinMaxElement => Driver.FindElement(By.XPath("//*[@id=\"resizable_max_min\"]/div[3]"));
    }
}
