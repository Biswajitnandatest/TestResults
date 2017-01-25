using System;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TestProject;
using System.Diagnostics;

namespace SeleniumTests
{
    [TestFixture]
    public class Valtechtestclass
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        private Homepage Testhomepage;
        private ServicesPage TestServicespage;
        private CareersPage TestCareerspage;
        private ContactsPage TestContactPage;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.valtech.com";
            verificationErrors = new StringBuilder();
            driver.Navigate().GoToUrl(baseURL);
            Testhomepage = new Homepage(driver);
            TestServicespage = new ServicesPage(driver);
            TestCareerspage = new CareersPage(driver);
            TestContactPage = new ContactsPage(driver);

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(45));
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }


        [Test]
        public void HomePageTest()
        {
            
            //Verify that Latest news is appearing
            Assert.AreEqual(Testhomepage.LatestNews.Text, "LATEST NEWS");

        }

        [Test]
        public void ServicesTest()
        {                      
            
            // Click on the services link from the Landing page 
            Testhomepage.Servicesfrommenu.Click();            

            // Verify that the h1 tag is having the text of Services in the Services page
            Assert.AreEqual(TestServicespage.H1Tag.Text, "Services");            

        }

        [Test]
        public void CareerTest()
        {

            // Click on the careers link from the Landing page 
            Testhomepage.Careersfrommenu.Click();
            Assert.AreEqual(TestCareerspage.H1Tag.Text,"Careers");

            
        }

        [Test]
        public void ContactsTest()
        {

            // Click on the careers link from the Landing page 
            Testhomepage.Contact.Click();
            
            //Console.WriteLine(TestContactPage.noofoffices());
          //Trace.WriteLine("No of offices are "+TestContactPage.noofoffices());
            //TestContext.WriteLine("No of offices are " + TestContactPage.noofoffices());
            Assert.AreEqual(TestContactPage.noofoffices(), 10);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
