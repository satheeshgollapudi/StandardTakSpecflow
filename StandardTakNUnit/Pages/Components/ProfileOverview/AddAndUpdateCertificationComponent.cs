using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using test.Utils;

namespace test.Pages.Components
{
    public class AddAndUpdatCertificationComponent : GobalHelper

    {

        private IWebElement certificateTextBox;
        private IWebElement fromTextBox;
        private IWebElement yearDropDown;
        private IWebElement addButton;
        private IWebElement cancelButton;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;
        private IWebElement updateButton;


        public void renderAddComponents()
        {
            try
            {
                certificateTextBox = driver.FindElement(By.XPath("//*[@name='certificationName']"));
                fromTextBox = driver.FindElement(By.XPath("//*[@name='certificationFrom']"));
                yearDropDown = driver.FindElement(By.XPath("//*[@name='certificationYear']"));
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
                certificateTextBox = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                fromTextBox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                yearDropDown = driver.FindElement(By.XPath("//select[@name='country']"));
                addButton = driver.FindElement(By.XPath("//input[@value='Add']"));
                cancelButton = driver.FindElement(By.XPath("//*[@value='Cancel']"));
                updateButton = driver.FindElement(By.XPath("//*[@value='Update']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void addCertification(Model.CertificationModel certificationtion)
        {
            renderAddComponents();

            //Enter record details
            certificateTextBox.SendKeys(certificationtion.getcertificate());
            fromTextBox.SendKeys(certificationtion.getfrom());
            SelectElement yearOption = new SelectElement(yearDropDown);
            yearOption.SelectByText(certificationtion.getyear());
            

            //Click on "Add" button.
            addButton.Click();
            Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);


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


    }
}

