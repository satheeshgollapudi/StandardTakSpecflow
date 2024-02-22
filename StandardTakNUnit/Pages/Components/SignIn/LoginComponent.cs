
using System;
using System.Threading;
using OpenQA.Selenium;
using test.Model;
using test.Utils;

namespace test.Pages.Components.SignIn
{
    public class LoginComponent : GobalHelper
	{


        private IWebElement emailTextbox;
        private IWebElement passwordTextbox;
        private IWebElement loginButton;



        public void renderComponents()
        {
            try
            {
                emailTextbox = driver.FindElement(By.XPath("//*[@placeholder='Email address']"));
                passwordTextbox = driver.FindElement(By.XPath("//*[@placeholder='Password']"));
                loginButton = driver.FindElement(By.XPath("//*[text()='Login']"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public void doSignIn(UserInformation userInformation)
        {

            renderComponents();

            //Enter the valid email address and password.
            emailTextbox.SendKeys(userInformation.getEmail());
            passwordTextbox.SendKeys(userInformation.getPassword());

            //Click on "Login" button
            loginButton.Click();
            Thread.Sleep(3000);

          


        }
    }




    }




