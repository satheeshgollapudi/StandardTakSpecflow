using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using test.AssertHelpers;
using test.Pages.Components;
using test.Steps;
using test.Utils;

namespace StandardTakNUnit.Tests
{
    [Binding]
    internal class EducationTest : GobalHelper
    {


        LoginSteps loginSteps;
        HomePageSteps homePageSteps;
        EducationSteps educationSteps;
        ProfileEducationOverviewComponent ProfileEducationOverviewComponent;
        AddAndUpdateEducationComponent addAndUpdateEducationComponent;


        public EducationTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();
            educationSteps = new EducationSteps();
            ProfileEducationOverviewComponent = new ProfileEducationOverviewComponent();
            addAndUpdateEducationComponent = new AddAndUpdateEducationComponent();


        }


        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {



            // Click on Language tab
            homePageSteps.clickOnEducationTab();

        }

        [When(@"I add a new Education")]
        public void WhenIAddANewLanguage()
        {
            educationSteps.addEducation();
        }


        [Then(@"that Education should be displayed on my listings")]
        public void ThenThatEducationShouldBeDisplayedOnMyListings()
        {



            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();
            AssertHelper.assertAddEducationSuccessMessage("Education has been added", acutalSuccessMessage);
            Console.WriteLine(acutalSuccessMessage);


        }


        [When(@"I add the same Education details again")]
        public void WhenIAddTheSameEducationDetailsAgain()
        {
            educationSteps.addExistingEducation();
        }

        [Then(@"I should able to get an error message (.*)")]
        public void ThenIShouldAbleToGetAnErrorMessage(string msg)
        {
            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage(msg, acutalSuccessMessage);
            Console.WriteLine(acutalSuccessMessage);
        }

        [When(@"I add a new education by missing one field")]
        public void WhenIAddANewEducationByMissingOneField()
        {
            educationSteps.addEducationNullValues();
        }

        [Then(@"there should be a pop up (.*)")]
        public void ThenThereShouldBeAPopUp(string msg)
        {
            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage(msg, acutalSuccessMessage);
            Console.WriteLine(acutalSuccessMessage);
        }

        [When(@"Try to Edit the Education and update")]
        public void WhenTryToEditTheEducationAndUpdate()
        {
            educationSteps.updateEducation();

        }


        [Then(@"that new Education should be displayed on my listings")]
        public void ThenThatNewEducationShouldBeDisplayedOnMyListings()
        {
            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage("Education as been updated", acutalSuccessMessage);
            Console.WriteLine(acutalSuccessMessage);
        }

    }


}
