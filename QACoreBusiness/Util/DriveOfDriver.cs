using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace QACoreBusiness.Util
{
    class DriveOfDriver                        
    {
        private static IWebDriver SaveDriver;
        public static void SetInstanceDrive(IWebDriver driver)
        {
            SaveDriver = driver;
        }

        public static IWebDriver GetInstanceDrive() => SaveDriver;
    }
}
