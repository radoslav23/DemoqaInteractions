using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.Selectable
{
    public partial class SelectablePage
    {
        public IWebElement TabSerial => Wait.Until(x => x.FindElement((By.Id("ui-id-3")))); 

        public IWebElement SelectionStartElement => Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[3]"));

        public IWebElement SelectionFinishElement => Driver.FindElement(By.XPath("//*[@id=\"selectable-serialize\"]/li[5]"));

        public IWebElement SelectionResult => Driver.FindElement(By.Id("select-result"));

    }
}
