using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.DroppablePage
{
    public partial class DroppablePage : BasePage
    {
        public DroppablePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/droppable/";
        }

        public void DefaultDropElement()
        {
            Action.ClickAndHold(SourseDropElement)
                .MoveToElement(TargetDropElement)
                .Release(TargetDropElement)
                .Build()
                .Perform();
        }

        public void ShoppingCartDragAndDrop()
        {
            TabShoppingCart.Click();
            Action.ClickAndHold(Product)
                .MoveToElement(ShoppingCart)
                .Release(ShoppingCart)
                .Build()
                .Perform();
        }
    }
}
