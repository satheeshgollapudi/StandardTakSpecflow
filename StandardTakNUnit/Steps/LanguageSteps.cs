using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;
using test.AssertHelpers;
using test.Model;
using test.Pages.components;
using test.Pages.Components;
using test.Utils;

namespace test.Steps.Pages.components
{
    public class LanguageSteps : GobalHelper
    {
        ProfileLanguageOverviewComponent ProfileLanguageOverviewComponent;
        AddAndUpdateLanguageComponent addAndUpdateLanguageComponent;

        public LanguageSteps()
        {

            ProfileLanguageOverviewComponent = new ProfileLanguageOverviewComponent();
            addAndUpdateLanguageComponent = new AddAndUpdateLanguageComponent();

        }

        public void addFourLanguages()
        {
            string path = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\TestData\FourLanguages.json";

            JsonReader jr = JsonReader.read(path);

            List<Model.LanguageModel> languages = new List<Model.LanguageModel>();

            foreach (var languageData in jr.Languages)
            {
                Model.LanguageModel language = new Model.LanguageModel();
                language.setLanguage(languageData.Language);
                language.setLevel(languageData.Level);
                languages.Add(language);
            }

            // Delete existing languages
            int Lan_totalrows = driver.FindElements(By.XPath("//th[contains(text(), 'Language')]/ancestor::table/descendant::tbody/tr")).Count;
            for (int i = Lan_totalrows; i >= 1; i--)
            {
                IWebElement deleteButton = driver.FindElement(By.XPath("//th[contains(text(), 'Language')]/ancestor::table/descendant::tbody[" + i + "]/tr/td[3]/span[2]"));
                deleteButton.Click();
                Lan_totalrows--;
            }

            // Wait for deletion to complete
            Thread.Sleep(3000);

            // Add new languages

            foreach (var language in languages)
            {
                ProfileLanguageOverviewComponent.clickAddLanguageButton();
                addAndUpdateLanguageComponent.addMaxLanguages(new List<Model.LanguageModel> { language });
            }
           
        }


  
        public void addLanguage()
        {
            Model.LanguageModel language = new Model.LanguageModel();

            string path = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\TestData\Language.json";


            JsonReader jr = JsonReader.read(path);

            language.setLanguage(jr.Language);
            language.setLevel(jr.Level);

            //Count rows of Language table
            int Lan_totalrows = driver.FindElements(By.XPath("//th[contains(text(), 'Language')]/ancestor::table/descendant::tbody/tr")).Count;
            //Validate with Language 
            //for (int i = 1; i <= Lan_totalrows; i++)
            for (int i = Lan_totalrows; i >= 1; i--)
            {
                //var actualLanguage = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//table[@class='ui fixed table']/tbody[" + i + "]/tr[1]/td[1]")).Text;
              
                var actualLanguage = driver.FindElement(By.XPath("//th[contains(text(), 'Language')]/ancestor::table/descendant::tbody[" + i + "]/tr/td[1]")).Text;
                string expectedLanguage = language.getLanguage();

                if (actualLanguage == expectedLanguage)
                {

                    IWebElement deleteButton = driver.FindElement(By.XPath("//th[contains(text(), 'Language')]/ancestor::table/descendant::tbody[" + i + "]/tr/td[3]/span[2]"));
                    deleteButton.Click();
                    Lan_totalrows--;

                }
            }

                Thread.Sleep(3000);
                ProfileLanguageOverviewComponent.clickAddLanguageButton();

                addAndUpdateLanguageComponent.addLanguage(language);

            }
        }

    }
