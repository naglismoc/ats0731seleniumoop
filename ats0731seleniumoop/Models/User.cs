using ats0731seleniumoop.Helpers;
using ats0731seleniumoop.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ats0731seleniumoop.Models
{
    internal class User
    {
        public static IWebDriver driver;
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }


        public User()
        {
            if (driver is null)
            {
                driver = Driver.driver;
            }
        }

        public User(string username, string email, string password1, string password2)
        {
            if (driver is null)
            {
                driver = Driver.driver;
            }
            Username = username;
            Email = email;
            Password1 = password1;
            Password2 = password2;
        }

        public void Register()
        {
            driver.Navigate().GoToUrl("https://elenta.lt/registracija");
            driver.FindElement(By.Id("UserName")).SendKeys(this.Username);
            driver.FindElement(By.Id("Email")).SendKeys(this.Email);
            driver.FindElement(By.Id("Password")).SendKeys(this.Password1);
            driver.FindElement(By.Id("Password2")).SendKeys(this.Password2);
            driver.FindElement(By.ClassName("bigNavBtn2")).Click();

        }

       

    }
}
