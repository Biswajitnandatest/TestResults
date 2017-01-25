using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject
{
    public class ServicesPage
    {
        //private IWebDriver driver;

        public ServicesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

 
        [FindsBy(How = How.TagName, Using = "h1")]
        public IWebElement H1Tag
        {
            get;
            set;
        }



    }
}
