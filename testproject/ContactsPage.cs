using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestProject
{
    public class ContactsPage
    {
        // protected IWebDriver driver;
        public int testcount;

        public ContactsPage()
        {
        }

        public ContactsPage(IWebDriver driver)
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);
         
        }


        [FindsBy(How = How.TagName, Using = "h1")]
        public IWebElement H1Tag
        {
            get;
            set;
        }

        [FindsBy(How = How.TagName, Using = "a")]        
        public IList<IWebElement> offices
        {
            get;
            set;
        }

        public int noofoffices()
        {

            int i = 0;
            int noofoffices = 0;    

           for(i=0;i<offices.Count;i++)
            {
                if ((offices[i].GetAttribute("href").Contains("contact")))
                {
                    noofoffices = noofoffices + 1;
                }



            }

            return noofoffices;

        }
    }
}

