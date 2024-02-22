using NUnit.Framework;
using test.Steps;
using test.Utils;

namespace test
{
    public class LoginTest : GobalHelper
    {

        LoginSteps loginSteps;
        HomePageSteps homePageSteps;

       public LoginTest()
        {
            loginSteps = new LoginSteps();
            homePageSteps = new HomePageSteps();

        }



        [Test]
        public void givenLoginCreds_whenDoLogin_thenIsLoggedIn()
        {
            //loginSteps.doLogin();
          

            homePageSteps.validateIsLoggedIn();
          

        }


    }

}

