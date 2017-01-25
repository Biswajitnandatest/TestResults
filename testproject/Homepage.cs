using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject
{
    public class Homepage
    {
        //private IWebDriver driver;

        public Homepage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How=How.XPath,Using = "//*[@id='navigationMenuWrapper']/div/ul/li[2]/a/span")]
        public IWebElement Servicesfrommenu
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='navigationMenuWrapper']/div/ul/li[5]/a/span")]
        public IWebElement Careersfrommenu
        {
            get;
            set;
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div[2]/div[3]/div[1]/header/h2")]
        public IWebElement LatestNews
        {
            get;
            set;
        }


        [FindsBy(How = How.TagName, Using = "h1")]        
        public IWebElement H1Tag
        {
            get;
            set;
        }

        

        [FindsBy(How = How.XPath, Using = "//*[@id='contacticon']/div/div/div[1]/i")]
        public IWebElement Contact
        {
            get;
            set;
        }


    }
}
