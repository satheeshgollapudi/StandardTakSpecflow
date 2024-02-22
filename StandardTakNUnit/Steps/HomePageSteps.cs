using System;
using test.Pages;
using test.Pages.Components.ProfileOverview;

namespace test.Steps
{
	public class HomePageSteps
	{

        private HomePage homePage;
        private ProfileMenuTabsComponents profileMenuTabsComponents;

        public HomePageSteps()
		{
            homePage = new HomePage();
             profileMenuTabsComponents = homePage.getProfileMenuTabsComponents();
        }


        public void clickOnCertificationTab()
        {
            profileMenuTabsComponents.clickCertificationTab();
        }


        public void clickOnEducationTab()
        {
            profileMenuTabsComponents.clickEducationTab();
        }



        public void clickOnLangaugesTab()
        {
            profileMenuTabsComponents.clickLangaugesTab();
        }


        public void clickOnSkillsTab()
        {
            profileMenuTabsComponents.clickSkillsTab();
        }

        public void validateIsLoggedIn()
        {
            homePage.getFirstName();

        }
    }
}

