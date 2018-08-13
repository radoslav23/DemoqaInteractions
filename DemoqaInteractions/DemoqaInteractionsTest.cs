using NUnit.Framework;
using System.IO;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DemoqaInteractions.Pages.DraggablePage;
using DemoqaInteractions.Pages.DroppablePage;
using DemoqaInteractions.Pages.ResizablePage;
using DemoqaInteractions.Pages.Selectable;
using DemoqaInteractions.Pages.AccordionPage;
using DemoqaInteractions.Pages.SortablePage;

//testing interaction section in Demoqa.com
namespace DemoqaInteractions
{
    [TestFixture]
    public class DemoqaInteractionsTest
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [TearDown]
        public void EndTest()
        {
            //take a screenshot in case of test failure
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenshotLocation = Path.GetFullPath(@"..\..\..\Screenshots\");
                string testName = TestContext.CurrentContext.Test.Name;
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotLocation + testName + ".png", ScreenshotImageFormat.Png);
            }
            driver.Close();
        }        
        
        [Test]
        public void DragElementTest()
        {
            //moves element on the left
            var draggablePage = new DraggablePage(driver);

            draggablePage.NavigateTo();
            draggablePage.DragElement();

            draggablePage.SourseElement.GetAttribute("style").Should().Be("position: relative; width: 246px; right: auto; height: 150px; bottom: auto; left: -239px; top: -69px;");
        }

        [Test]
        public void DragElementVerticalTest()
        {
            //moves element vertical
            var draggablePage = new DraggablePage(driver);

            draggablePage.NavigateTo();
            draggablePage.DragElementVertical();

            draggablePage.SourseElementVertical.GetAttribute("style").Should().Be("position: relative; height: 90px; bottom: auto; left: 0px; top: 176px;");
        }

        [Test]
        public void DefaultElementDropTest()
        {
            //drops element to his box
            var droppablePage = new DroppablePage(driver);

            droppablePage.NavigateTo();
            droppablePage.DefaultDropElement();

            droppablePage.SuccessDroped.Text.Contains("Dropped!").Should().BeTrue();
        }

        [Test]
        public void ShoppingCartDragAndDropTest()
        {
            //moves Cheezeburger Shirt to shopping cart
            var droppablePage = new DroppablePage(driver);

            droppablePage.NavigateTo();
            droppablePage.ShoppingCartDragAndDrop();

            droppablePage.ShoppingCart.Text.Contains("Cheezeburger Shirt").Should().BeTrue();
        }

        [Test]
        public void MinMaxElementResizeTest()
        {
            //resize element to make it smaller or larger
            var resizablePage = new ResizablePage(driver);

            resizablePage.NavigateTo();
            var resizableElementWidthBefore = resizablePage.MinMaxElement.Size.Width;
            var resizableElementHeightBefore = resizablePage.MinMaxElement.Size.Height;
            resizablePage.MinMaxElementResize();

            resizablePage.MinMaxElement.Size.Width.Should().NotBe(resizableElementWidthBefore);
            resizablePage.MinMaxElement.Size.Height.Should().NotBe(resizableElementHeightBefore);
        }

        [Test]
        public void SelectSerialElementsTest()
        {
            //select item 3,4,5
            var selectablePage = new SelectablePage(driver);

            selectablePage.NavigateTo();
            selectablePage.SelectSerialElements();

            selectablePage.SelectionResult.Text.Contains("#3#4#5").Should().BeTrue();
        }

        [Test]
        public void DefaultElementSortTest()
        {
            //move Item 1 to seventh position
            var sortablePage = new SortablePage(driver);

            sortablePage.NavigateTo();
            sortablePage.DefaultElementSort();

            sortablePage.SelectSeventh.Text.Should().Be("Item 1");
        }

        [Test]
        public void VerifyIconsAreNotToggle()
        {
            //verify icons are not toggle when navigate to Customize icons tab
            var accorditionPage = new AccordionPage(driver);

            accorditionPage.NavigateTo();
            accorditionPage.GoToCustomizeIconsTab();

            accorditionPage.SectionFour.GetAttribute("class").Should()
                .Be("ui-accordion-header ui-state-default ui-corner-all ui-accordion-icons");
        }

        [Test]
        public void VerifyIconsAreToggleAfterClickButton()
        {
            //verify icons are toggle after clicking toggle button
            var accorditionPage = new AccordionPage(driver);

            accorditionPage.NavigateTo();
            accorditionPage.GoToCustomizeIconsTab();
            accorditionPage.ClickingToggleIconsButton();

            accorditionPage.SectionFour.GetAttribute("class").Should()
                .NotBe("ui-accordion-header ui-state-default ui-corner-all ui-accordion-icons");
        }
    }
}