using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ats0731seleniumoop.Helpers
{
    internal class CustomAsserts
    {
        public static IWebDriver driver;
        public static void AssertEqualsId(string idtofind, string expected)
        {
            if (driver is null)
            {
                driver = Driver.driver;
            }

            string actual = "";
            try
            {        
                actual = driver.FindElement(By.Id(idtofind)).Text;
            }
            catch (Exception ex)
            {
                Assert.Fail("searched element not found");
            }
            Assert.AreEqual(expected, actual);
        }

        public static void AssertEqualsXPath(string xpathtofind, string expected)
        {
            if (driver is null)
            {
                driver = Driver.driver;
            }
            string actual = "";
            try
            {
                actual = driver.FindElement(By.XPath(xpathtofind)).Text;
            }
            catch (Exception ex)
            {
                Assert.Fail("searched element not found");
            }
            Assert.AreEqual(expected, actual);
        }

        public static void AssertEqualsClassName(string classNameToFind, string expected)
        {
            if (driver is null)
            {
                driver = Driver.driver;
            }
            string actual = "";
            try
            {
                actual = driver.FindElement(By.ClassName(classNameToFind)).Text;
            }
            catch (Exception ex)
            {
                Assert.Fail("searched element not found");
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
