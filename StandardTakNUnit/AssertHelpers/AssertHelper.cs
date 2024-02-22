
using System;
using NUnit.Framework;

namespace test.AssertHelpers
{
	public class AssertHelper
	{

		public static void assertAddEducationSuccessMessage(String expected, String actual) {

			Assert.AreEqual(expected, actual, "succes message is correct for add education");

        }

        public static void assertAddLanguageSuccessMessage(String expected, String actual)
        {

            Assert.AreEqual(expected, actual, "succes message is correct for add Language");

        }


        public static void assertAddSkillsSuccessMessage(String expected, String actual)
        {

            Assert.AreEqual(expected, actual, "succes message is correct for add Skills");

        }

        public static void assertAddCertificationSuccessMessage(String expected, String actual)
        {

            Assert.AreEqual(expected, actual, "succes message is correct for add Certification");

        }
    }
}

