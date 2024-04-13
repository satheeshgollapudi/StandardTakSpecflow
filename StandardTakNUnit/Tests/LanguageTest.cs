using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using test.AssertHelpers;
using test.Pages.components;
using test.Pages.Components;
using test.Steps;
using test.Steps.Pages.components;
using test.Model;
using NUnit.Framework;
using RazorEngine;
using System.Security.Policy;

namespace StandardTakNUnit.Tests
{
    [Binding]
    internal class LanguageTest
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        LanguageSteps languageSteps;
        ProfileLanguageOverviewComponent ProfileLanguageOverviewComponent;
        AddAndUpdateLanguageComponent addAndUpdateLanguageComponent;


        public LanguageTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            languageSteps = new LanguageSteps();
            ProfileLanguageOverviewComponent = new ProfileLanguageOverviewComponent();
            addAndUpdateLanguageComponent = new AddAndUpdateLanguageComponent();


        }


        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {

            // Click on Language tab
            homePageSteps.clickOnLangaugesTab();

        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {

          
            languageSteps.addLanguage();
        }


        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {

            LanguageModel language = new LanguageModel();
            String acutalSuccessMessage = addAndUpdateLanguageComponent.getSuccessMessage();
            AssertHelper.assertAddLanguageSuccessMessage("English has been added to your languages", acutalSuccessMessage);
            Console.WriteLine(acutalSuccessMessage);
        }

       

        [When(@"I add four new Languages")]
        public void WhenIAddFourNewLanguages()
        {
            languageSteps.addFourLanguages();
        }

        [Then(@"should be able to add four languages only")]
        public void ThenShouldBeAbleToAddFourLanguagesOnly()
        {
            addAndUpdateLanguageComponent.CheckLanguageButtonAvailability();
        }


    }
}
