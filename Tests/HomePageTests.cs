using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SauceDemoTests.Tests;

/// <summary>
/// Y1 - Test dau tien: mo trang saucedemo va kiem tra tieu de trang.
/// </summary>
[TestFixture]
public class HomePageTests
{
    private const string BaseUrl = "https://www.saucedemo.com/";
    private IWebDriver driver = null!;

    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        driver?.Quit();
        driver?.Dispose();
    }

    [Test]
    public void MoTrangChu_TieuDeLaSwagLabs()
    {
        driver.Navigate().GoToUrl(BaseUrl);

        TestContext.Out.WriteLine($"Tieu de trang: {driver.Title}");
        Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
    }
}
