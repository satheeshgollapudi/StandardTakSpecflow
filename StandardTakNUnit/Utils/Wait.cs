﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace test.Utils
{
	public class Wait
	{
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(locatorValue)));
              
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(locatorValue)));
            }
        }
        public static void WaitToExist(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(locatorValue)));
            }
        }
        public static void WaitToBeVisible(IWebDriver driver, string locator, string locatorValue, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));

            if (locator == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locatorValue)));
            }
            if (locator == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(locatorValue)));
            }
            if (locator == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(locatorValue)));
            }
        }
    }
}

