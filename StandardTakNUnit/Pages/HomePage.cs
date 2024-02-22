using System;
using OpenQA.Selenium;
using test.Utils;

namespace test.Pages.Components.ProfileOverview
{
	public class HomePage : GobalHelper
	{

        private IWebElement userNameLabel;
        private ProfileMenuTabsComponents profileMenuTabsComponents;


        public HomePage()
		{
			profileMenuTabsComponents = new ProfileMenuTabsComponents();

        }


        public void renderComponents()
        {
            try
            {
                userNameLabel = driver.FindElement(By.XPath("//span[contains(@class,'item ui')]"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }


        public ProfileMenuTabsComponents getProfileMenuTabsComponents()
		{
			return profileMenuTabsComponents;

        }



        public String getFirstName()
        {
            //Return username
            try
            {
                renderComponents();
                return userNameLabel.Text;

            }
            catch (Exception ex)
            {
                driver.Navigate().Refresh();
                return ex.Message;
            }
        }
    }
}

