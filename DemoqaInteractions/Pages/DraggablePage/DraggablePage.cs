using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.DraggablePage
{
    public partial class DraggablePage : BasePage
    {
        public DraggablePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/draggable/";
        }

        public void DragElement()
        {
            Action.ClickAndHold(SourseElement)
                .MoveToElement(TargetElement)
                .Release(TargetElement)
                .Build()
                .Perform();
        }

        public void DragElementVertical()
        {
            TabConstrainMove.Click();
            Action.ClickAndHold(SourseElementVertical)
                .MoveToElement(TargetElementVertical)
                .Release(TargetElementVertical)
                .Build()
                .Perform();
        }
    }
}
