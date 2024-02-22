using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using test.Pages;

namespace test.Utils
{


    public class CommonMethods
    {
        //Screenshots
        

        public class SaveScreenShotClass
        {

            public static string SaveScreenshot(IWebDriver driver, string ScreenShotFileName) // Definition
            {
                var folderLocation = (ConstantHelpers.ScreenshotPath);

                if (!System.IO.Directory.Exists(folderLocation))
                {
                    System.IO.Directory.CreateDirectory(folderLocation);
                }

                var screenShot = ((ITakesScreenshot)driver).GetScreenshot();
                var fileName = new StringBuilder(folderLocation);

                fileName.Append(ScreenShotFileName);
                fileName.Append(System.DateTime.Now.ToString("_dd-mm-yyyy_mss"));
                //fileName.Append(DateTime.Now.ToString("dd-mm-yyyym_ss"));
                fileName.Append(".Png");
                screenShot.SaveAsFile(fileName.ToString(), ScreenshotImageFormat.Png);
                return fileName.ToString();
            }
        }

        //ExtentReports
        #region reports

        public static ExtentReports extent;
        public static ExtentTest test;
        private static ExtentHtmlReporter htmlReporter;

        //public static object Extent { get; internal set; }

        public static void ExtentReports()
        {
           
                string reportPath = @"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTakSpecflow\StandardTakNUnit\Reports\Report.html"; // Specify the path where you want to save the report

                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }





        }




    }



        
    #endregion
