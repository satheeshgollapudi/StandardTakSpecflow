using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V116.Debugger;
using test.Utils;

namespace test.Pages.components
{
    public class ProfileLanguageOverviewComponent : GobalHelper

    {

        private IWebElement languagesTitle;
        private IWebElement languagesSubHeading1;
        private IWebElement languagesSubHeading2;
        private IWebElement addLanguageButton;
        private IWebElement inputLanguageTextBox;
        private IWebElement chooseLanguage;
        private IWebElement addButton;
        private IWebElement cancelButton;
        private string message = "";


        public void renderComponents()
        {
            try
            {
                languagesTitle = driver.FindElement(By.XPath("(//h3[@class='alt'])[1]"));
                languagesSubHeading1 = driver.FindElement(By.XPath("(//div[@class='question'])[1]"));
                languagesSubHeading2 = driver.FindElement(By.XPath("(//div[@class='tooltip'])[1]"));
                //languages = driver.FindElements(By.XPath("//table[contains(@class,'ui fixed')]/tbody"));
                addLanguageButton = driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button')])[1]"));
                inputLanguageTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                chooseLanguage = driver.FindElement(By.XPath(" //select[@class='ui dropdown']"));
                addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                cancelButton = driver.FindElement(By.XPath("//input[@value='Cancel']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void clickAddLanguageButton()
        {

            //----Adding Education------------

            renderComponents();
            addLanguageButton.Click();

            Thread.Sleep(5000);
        }

        public void CheckLanguageButtonAvailability()
        {

            renderComponents();

            int Lan_totalrows = driver.FindElements(By.XPath("//th[contains(text(),'Language')]/parent::tr/parent::thead/following-sibling::tbody/tr")).Count;

            if (Lan_totalrows==4 && addLanguageButton.Displayed)
            {
                // Language button is  available
                Console.WriteLine("can add more than four languages.");
                Assert.Fail();
               

            }
            else
            {
                

                // Language button is not available
                Console.WriteLine("can add more than four languages");
                
            }
        }


        //public void closeMessageWindow()
        //{
        //    Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
        //    closeMessageIcon.Click();
        //}


        public string getMessage()
        {
            //Returning error or success message
            return message;
        }





    }
}

