using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.SortablePage
{
    public partial class SortablePage
    {
        public IWebElement SelectFirst => Driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[1]")); 
        
        public IWebElement SelectSeventh => Driver.FindElement(By.XPath(@"//*[@id=""sortable""]/li[7]"));
    }
}
