using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.Selectable
{
    public partial class SelectablePage : BasePage
    {
        public SelectablePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/selectable/";
        }

        public void SelectSerialElements()
        {
            TabSerial.Click();
            Action.ClickAndHold(SelectionStartElement)
                .MoveToElement(SelectionStartElement);
            Action.MoveToElement(SelectionFinishElement)
                .Click()
                .Build()
                .Perform();
        }
    }
}
