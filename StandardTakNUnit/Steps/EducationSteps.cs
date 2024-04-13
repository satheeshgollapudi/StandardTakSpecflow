
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using test.AssertHelpers;
using test.Model;
using test.Pages.components;
using test.Pages.Components;
using test.Utils;

namespace test.Steps
{
    public class EducationSteps : GobalHelper
    {
        ProfileEducationOverviewComponent ProfileEducationOverviewComponent;
        AddAndUpdateEducationComponent addAndUpdateEducationComponent;

        public EducationSteps()
        {

            ProfileEducationOverviewComponent = new ProfileEducationOverviewComponent();
            addAndUpdateEducationComponent = new AddAndUpdateEducationComponent();

        }


        public void addEducation()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\TestData\Education.json";


            JsonReader er = JsonReader.read(path);
            education.setCountry(er.country);
            education.setDegree(er.degree);
            education.setGraduationYear(er.graduationYear);
            education.setTitle(er.title);
            education.setUniversity(er.university);


            //Count rows of Education table
            int Edu_totalrows = driver.FindElements(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody/tr")).Count;
            //Validate with Education Title and Degree
            //for (int i = 1; i <= Edu_totalrows; i++)
            for (int i = Edu_totalrows; i >= 1; i--)
            {
                var actualTitle = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[3]")).Text;
                var actualDegree = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[4]")).Text;


                string expectedTitle = education.getTitle();
                string expectedDegree = education.getDegree();



                if (actualTitle == expectedTitle && actualDegree == expectedDegree)
                {

                    IWebElement deleteButton = driver.FindElement(By.XPath("//td[text()='" + education.getTitle() + "']/ancestor::tbody/descendant::i[2]"));
                    deleteButton.Click();

                }
            }
            Thread.Sleep(3000);
            ProfileEducationOverviewComponent.clickAddEducationButton();
            addAndUpdateEducationComponent.addEducation(education);

        }

        public void addExistingEducation()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\TestData\Education.json";


            JsonReader er = JsonReader.read(path);
            education.setCountry(er.country);
            education.setDegree(er.degree);
            education.setGraduationYear(er.graduationYear);
            education.setTitle(er.title);
            education.setUniversity(er.university);

            //Count rows of Education table
            int Edu_totalrows = driver.FindElements(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody/tr")).Count;
            //Validate with Education Title and Degree
            for (int i = Edu_totalrows; i >= 1; i--)
            {
                var actualTitle = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[3]")).Text;
                var actualDegree = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[4]")).Text;


                string expectedTitle = education.getTitle();
                string expectedDegree = education.getDegree();



                if (actualTitle == expectedTitle && actualDegree == expectedDegree)
                {

                    IWebElement deleteButton = driver.FindElement(By.XPath("//td[text()='" + education.getTitle() + "']/ancestor::tbody/descendant::i[2]"));
                    deleteButton.Click();
                }
            }
            Thread.Sleep(3000);

            ProfileEducationOverviewComponent.clickAddEducationButton();
            addAndUpdateEducationComponent.addEducation(education);
            Thread.Sleep(3000);
            ProfileEducationOverviewComponent.clickAddEducationButton();
            addAndUpdateEducationComponent.addEducation(education);


        }

        public void addEducationNullValues()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\TestData\EducationNullValues.json";


            JsonReader er = JsonReader.read(path);
            education.setCountry(er.country);
            education.setDegree(er.degree);
            education.setGraduationYear(er.graduationYear);
            education.setTitle(er.title);
            education.setUniversity(er.university);

            //Count rows of Education table
            int Edu_totalrows = driver.FindElements(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody/tr")).Count;
            //Validate with Education Title and Degree
            for (int i = Edu_totalrows; i >= 1; i--)
            {
                var actualTitle = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[3]")).Text;
                var actualDegree = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[4]")).Text;


                string expectedTitle = education.getTitle();
                string expectedDegree = education.getDegree();



                if (actualTitle == expectedTitle && actualDegree == expectedDegree)
                {

                    IWebElement deleteButton = driver.FindElement(By.XPath("//td[text()='" + education.getTitle() + "']/ancestor::tbody/descendant::i[2]"));
                    deleteButton.Click();
                }
            }
            Thread.Sleep(3000);


            ProfileEducationOverviewComponent.clickAddEducationButton();

            addAndUpdateEducationComponent.addEducationNullValues(education);

        }

        public void updateEducation()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\TestData\UpdateEducation.json";


            JsonReader er = JsonReader.read(path);
            education.setCountry(er.country);
            education.setDegree(er.degree);
            education.setGraduationYear(er.graduationYear);
            education.setTitle(er.title);
            education.setUniversity(er.university);



            IWebElement updateButton = driver.FindElement(By.XPath("//td[text()='" + education.getTitle() + "']/ancestor::tbody/descendant::i[1]"));

            updateButton.Click();

            addAndUpdateEducationComponent.updateEducation(education);
            ProfileEducationOverviewComponent.clickupdateEducationButton();
        }


        public void deleteEducation()
        {
            Model.EducationModel education = new Model.EducationModel();


            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\Education.json";


            JsonReader er = JsonReader.read(path);
            education.setTitle(er.title);

            addAndUpdateEducationComponent.deleteEducation(education);

            String acutalSuccessMessage = addAndUpdateEducationComponent.getSuccessMessage();

            AssertHelper.assertAddEducationSuccessMessage("Education entry successfully removed", acutalSuccessMessage);
        }
    }
}

