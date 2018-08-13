using OpenQA.Selenium;

namespace DemoqaInteractions.Pages.SortablePage
{
    public partial class SortablePage : BasePage
    {
        public SortablePage(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo()
        {
            Driver.Url = "http://demoqa.com/sortable/";
        }

        public void DefaultElementSort()
        {
            Action.DragAndDropToOffset(SelectFirst, 0, 200);
            Action.Build()
                .Perform();
        }
    }
}
