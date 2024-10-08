﻿using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using test.Model;
using test.Utils;

namespace test.Pages.Components
{
    public class AddAndUpdateLanguageComponent : GobalHelper

    {

        private IWebElement languageTextBox;
        private IWebElement levelDropDown;
        private IWebElement addButton;
        private IWebElement cancelButton;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;
        private IWebElement updateButton;


        public void renderAddComponents()
        {
            try
            {
                languageTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                levelDropDown = driver.FindElement(By.XPath("//select[@name='level']"));
                addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                cancelButton = driver.FindElement(By.XPath("//*[@value='Cancel']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void renderAddMessage()
        {
            try
            { 

                messageWindow = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
                closeMessageIcon = driver.FindElement(By.XPath("//*[@class='ns-close']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void renderUpdateComponents()
        {
            try
            {
                languageTextBox = driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
                levelDropDown = driver.FindElement(By.XPath("//select[@name='level']"));
                cancelButton = driver.FindElement(By.XPath("//*[@value='Cancel']"));
                updateButton = driver.FindElement(By.XPath("//*[@value='Update']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void addLanguage(Model.LanguageModel language)
           
        {
              renderAddComponents();

            //Enter record details
            languageTextBox.SendKeys(language.getLanguage());           
            SelectElement levelOption = new SelectElement(levelDropDown);
            levelOption.SelectByText(language.getLevel());           
            //Click on "Add" button.
            addButton.Click();
            Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);


        }

        public void addMaxLanguages(List<Model.LanguageModel> language)
        {
            foreach (var languages in language)
            {
                renderAddComponents();

                // Enter record details
                languageTextBox.SendKeys(languages.getLanguage());
                SelectElement levelOption = new SelectElement(levelDropDown);
                levelOption.SelectByText(languages.getLevel());
                // Click on "Add" button.
                addButton.Click();
                Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            }
        }


        public String getSuccessMessage()
        {
            //Saving error or success message
            renderAddMessage();
            String message = messageWindow.Text;

            //If any message visible close it
            Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
            closeMessageIcon.Click();

            if (message == "Please enter all the fields")
            {
                cancelButton.Click();
            }

            return message;
        }


        public void CheckLanguageButtonAvailability()
        {

            int Lan_totalrows = driver.FindElements(By.XPath("//th[contains(text(),'Language')]/parent::tr/parent::thead/following-sibling::tbody/tr")).Count;

            IWebElement addLanguageButton = driver.FindElement(By.XPath("(//div[contains(@class,'ui teal button')])[1]"));

            if (Lan_totalrows == 4 && addLanguageButton.Displayed)
            {
                // Language button is  available
                Console.WriteLine("can add more than four languages.");
                Assert.Fail();


            }
            else
            {


                // Language button is not available
                Console.WriteLine("Can Not add more than four languages");


            }
        }


    } 
        }


