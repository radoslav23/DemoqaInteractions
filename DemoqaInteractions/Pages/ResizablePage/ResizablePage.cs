using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.ResizablePage
{
    public partial class ResizablePage : BasePage
    {
        public ResizablePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/resizable/";
        }

        public void MinMaxElementResize()
        {
            TabMinMax.Click();
            Action.ClickAndHold(MinMaxElement)
                .MoveByOffset(260, 360)
                .Release()
                .Build()
                .Perform();
        }
    }
}
