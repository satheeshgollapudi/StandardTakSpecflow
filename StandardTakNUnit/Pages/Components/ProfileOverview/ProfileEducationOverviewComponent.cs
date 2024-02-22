using System;
using System.Threading;
using OpenQA.Selenium;
using test.Utils;

namespace test.Pages.Components
{
    public class ProfileEducationOverviewComponent : GobalHelper

    {

        private IWebElement addNewEducationButton;
        private IWebElement newCountryAddedCell;
        private IWebElement newUniversityAddedCell;
        private IWebElement newTitleAddedCell;
        private IWebElement newDegreeAddedCell;
        private IWebElement newGraduationYearAddedCell;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;
        private string message = "";
        private IWebElement updateButton;


        public void renderComponents()
        {
            try
            {
                addNewEducationButton = driver.FindElement(By.XPath("//*[text()='Country']/following-sibling::th[5]/div"));
                updateButton = driver.FindElement(By.XPath("//*[@value='Update']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void clickAddEducationButton()
        {

            //----Adding Education------------

            renderComponents();
            addNewEducationButton.Click();

            Thread.Sleep(5000);
        }

        public void clickupdateEducationButton()
        {

            //----Update Education------------

            renderComponents();
            updateButton.Click();

            Thread.Sleep(5000);
        }



        public void closeMessageWindow()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@class='ns-close']", 5);
            closeMessageIcon.Click();
        }


        public string getMessage()
        {
            //Returning error or success message
            return message;
        }
    }
}

