using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.DroppablePage
{
    public partial class DroppablePage
    {
        public IWebElement SourseDropElement => Driver.FindElement(By.XPath("//*[@id=\"draggableview\"]/p"));

        public IWebElement TargetDropElement => Driver.FindElement(By.Id("droppableview"));

        public IWebElement SuccessDroped => Driver.FindElement(By.XPath("//*[@id=\"droppableview\"]/p"));

        public IWebElement TabShoppingCart => Wait.Until(x => x.FindElement((By.Id("ui-id-5"))));

        public IWebElement Product => Driver.FindElement(By.XPath("//*[@id=\"ui-id-7\"]/ul/li[2]"));
   
        public IWebElement ShoppingCart => Driver.FindElement(By.XPath("//*[@id=\"cart\"]/div/ol/li"));
    }
}
