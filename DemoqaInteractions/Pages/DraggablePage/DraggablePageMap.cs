using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.DraggablePage
{
    public partial class DraggablePage
    {
        public IWebElement SourseElement => Driver.FindElement(By.XPath("//*[@id=\"draggable\"]")); 
        
        public IWebElement TargetElement => Driver.FindElement(By.ClassName("ui-corner-left")); 

        public IWebElement TabConstrainMove => Wait.Until(x => x.FindElement(By.Id("ui-id-2"))); 

        public IWebElement SourseElementVertical => Driver.FindElement(By.Id("draggabl")); 

        public IWebElement TargetElementVertical => Driver.FindElement(By.Id("containment-wrapper")); 
    }
}
