using NUnit.Framework;
using OpenQA.Selenium;
using System;
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

                    IWebElement deleteButton = driver.FindElement(By.XPath("//td[text()='" + language.getLanguage() + "']/ancestor::tbody/descendant::i[2]"));
                    deleteButton.Click();
                    Lan_totalrows--;

                }
            }

            if (Lan_totalrows == 4)
            {


                IWebElement deleteButton = driver.FindElement(By.XPath("//th[contains(text(), 'Language')]/ancestor::table/descendant::tbody[1]/tr/td[3]/span/i[@class='remove icon']"));
                deleteButton.Click();

            }


            Thread.Sleep(3000);
            ProfileLanguageOverviewComponent.clickAddLanguageButton();

            addAndUpdateLanguageComponent.addLanguage(language);


        }



    }
}

