using OpenQA.Selenium;
using System;
using test.Utils;

namespace test.Pages
{


    public class SplashPage : GobalHelper
    {

        private IWebElement signInButton;


        public void renderComponents()
        {
            try
            {
                signInButton = driver.FindElement(By.XPath("//*[text()='Sign In']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void clickSignInButton()
        {

            //Click on "Sign In" button
            Wait.WaitToBeClickable(driver, "XPath", "//*[text()='Sign In']", 10);

            renderComponents();
            signInButton.Click();

        }




    }
}

