
using System;
using test.Model;
using test.Pages;
using test.Pages.Components.SignIn;
using test.Utils;

namespace test.Steps
{
    public class LoginSteps
    {
        SplashPage loginPage;
        LoginComponent loginComponent;

        public LoginSteps()
        {
            loginPage = new SplashPage();
            loginComponent = new LoginComponent();
        }


        public void doLogin()
        {
            UserInformation userInformation = new UserInformation();

            string path = @"C:\Users\gskum\OneDrive\Desktop\StandardTakNUnit\StandardTakNUnit\TestData\UserInformation.json";
            JsonReader jr = JsonReader.read(path);
            userInformation.setEmail(jr.email);
            userInformation.setPassword(jr.password);

            loginPage.clickSignInButton();
            loginComponent.doSignIn(userInformation);
        }

    }
}

