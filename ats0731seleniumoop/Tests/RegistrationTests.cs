using ats0731seleniumoop.Helpers;
using ats0731seleniumoop.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ats0731seleniumoop.Tests
{
	public class RegistrationTests
    {
        public static IWebDriver driver;

        [Test]
		public void positiveRegTest()
		{
			User u = new User("varstoasstssojas", "vartoatsojsasoesmailas@gmail.com", "qwertyqwerty", "qwertyqwerty");
			u.Register();
			CustomAsserts.AssertEqualsXPath("//*[@id=\"main-container\"]/div[2]/h1/b", "Jūs sėkmingai prisiregistravote!");
        }

		[Test]
		public void RegNoUsernameTest()
		{
			Models.User u = new User("", "vartotojoemailas@gmail.com", "qwertyqwerty", "qwertyqwerty");
			u.Register();
            CustomAsserts.AssertEqualsXPath( "//*[@id=\"main-container\"]/form/fieldset/table/tbody/tr[1]/td[2]/span", "Įveskite vartotojo vardą.");
		}

		[OneTimeSetUp]
		public void Initialize()
		{	
			if(Driver.driver is not null)
			{
				return;
			}
			Driver.driver = new ChromeDriver();

			driver = Driver.driver;
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
			driver.Manage().Window.Maximize();
			AcceptCookies();
		}

		[OneTimeTearDown]
		public void Clenaup()
		{
			//driver.Quit();
		}
		public void AcceptCookies()
		{
			driver.Navigate().GoToUrl("https://www.elenta.lt");
            driver.FindElement(By.XPath("/html/body/div[5]/div[2]/div[1]/div[2]/div[2]/button[1]")).Click();
		}

	}
}