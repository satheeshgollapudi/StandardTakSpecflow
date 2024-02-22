using System;
using System.Threading;
using OpenQA.Selenium;
using test.Utils;

namespace test.Pages.Components.ProfileOverview
{
    public class ProfileMenuTabsComponents : GobalHelper

    {

        private IWebElement languagesTab;
        private IWebElement skillsTab;
        private IWebElement educationTab;
        private IWebElement certificationsTab;


        public void renderComponents()
        {
            try
            {
                languagesTab = driver.FindElement(By.XPath("//a[text()='Languages']"));
                skillsTab = driver.FindElement(By.XPath("//a[text()='Skills']"));
                educationTab = driver.FindElement(By.XPath("//a[text()='Education']"));
                certificationsTab = driver.FindElement(By.XPath("//a[text()='Certifications']"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public void clickCertificationTab()
        {
            renderComponents();
            certificationsTab.Click();
            Thread.Sleep(1000);

        }

        public void clickLangaugesTab()
        {
            renderComponents();
            languagesTab.Click();
            Thread.Sleep(1000);


        }

        public void clickEducationTab()
        {
            renderComponents();
            educationTab.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//a[text()='Education']", 5);
        }

        public void clickSkillsTab()
        {
            renderComponents();
            skillsTab.Click();
            Thread.Sleep(1000);


        }
    }
}

