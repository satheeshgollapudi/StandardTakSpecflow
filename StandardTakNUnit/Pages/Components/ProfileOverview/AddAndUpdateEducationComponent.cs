using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using test.Utils;

namespace test.Pages.Components
{
    public class AddAndUpdateEducationComponent : GobalHelper

    {

        private IWebElement universityTextBox;
        private IWebElement degreeTextBox;
        private IWebElement countryDropDown;
        private IWebElement titleDropDown;
        private IWebElement graduationYearDropDown;
        private IWebElement addButton;
        private IWebElement cancelButton;
        private IWebElement messageWindow;
        private IWebElement closeMessageIcon;
        private IWebElement updateButton;
        private IWebElement deleteButton;


        public void renderAddComponents()
        {
            try
            {
                universityTextBox = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                degreeTextBox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                countryDropDown = driver.FindElement(By.XPath("//select[@name='country']"));
                titleDropDown = driver.FindElement(By.XPath("//select[@name='title']"));
                graduationYearDropDown = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
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
                universityTextBox = driver.FindElement(By.XPath("//input[@placeholder='College/University Name']"));
                degreeTextBox = driver.FindElement(By.XPath("//input[@placeholder='Degree']"));
                countryDropDown = driver.FindElement(By.XPath("//select[@name='country']"));
                titleDropDown = driver.FindElement(By.XPath("//select[@name='title']"));
                graduationYearDropDown = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
                cancelButton = driver.FindElement(By.XPath("//*[@value='Cancel']"));
                updateButton = driver.FindElement(By.XPath("//*[@value='Update']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        
        public void addEducation(Model.EducationModel education)
        {
            renderAddComponents();

            //Enter record details
            universityTextBox.SendKeys(education.getUniversity());
            degreeTextBox.SendKeys(education.getDegree());
            SelectElement countryOption = new SelectElement(countryDropDown);
            countryOption.SelectByText(education.getCountry());
            SelectElement titleOption = new SelectElement(titleDropDown);
            titleOption.SelectByText(education.getTitle());
            SelectElement graduationYearOption = new SelectElement(graduationYearDropDown);
            graduationYearOption.SelectByText(education.getGraduationYear());
            Thread.Sleep(3000);
            //Click on "Add" button.
            addButton.Click();
            Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);


        }

        public void addEducationNullValues(Model.EducationModel education)
        {
            renderAddComponents();

            //Enter record details
            //universityTextBox.SendKeys(education.getUniversity());
            degreeTextBox.SendKeys(education.getDegree());
            SelectElement countryOption = new SelectElement(countryDropDown);
            countryOption.SelectByText(education.getCountry());
            SelectElement titleOption = new SelectElement(titleDropDown);
            titleOption.SelectByText(education.getTitle());
            SelectElement graduationYearOption = new SelectElement(graduationYearDropDown);
            graduationYearOption.SelectByText(education.getGraduationYear());

            //Click on "Add" button.
            addButton.Click();
            Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);


        }

        public void updateEducation(Model.EducationModel education)
        {
            renderUpdateComponents();

            
           

            //Enter record details
            universityTextBox.Clear();
            universityTextBox.SendKeys(education.getUniversity());
            degreeTextBox.Clear();
            degreeTextBox.SendKeys(education.getDegree());
            SelectElement countryOption = new SelectElement(countryDropDown);
            countryOption.SelectByText(education.getCountry());
            SelectElement titleOption = new SelectElement(titleDropDown);
            titleOption.SelectByText(education.getTitle());
            SelectElement graduationYearOption = new SelectElement(graduationYearDropDown);
            graduationYearOption.SelectByText(education.getGraduationYear());

            

          


        }

        public void deleteEducation(Model.EducationModel education)
        {
            try
            {
                //deleteButton = driver.FindElement(By.XPath("(//h3[text()='Education']/parent::div/parent::div/child::div[2]/descendant::i[@class=\"remove icon\"])[1]"));
                IWebElement deleteButton = driver.FindElement(By.XPath("//td[text()='"+education.getTitle()+"']/ancestor::tbody/descendant::i[2]"));
                deleteButton.Click();
                Wait.WaitToExist(driver, "XPath", "//div[@class='ns-box-inner']", 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



            public String getSuccessMessage()
        {
            renderAddComponents();
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

