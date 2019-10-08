using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AishaSelenium_Task2
{
    class Program
    {
        [Test]
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //login
            LoginTestCases login = new LoginTestCases(driver); //creating an object of 'logintestcases'
            login.LoginPage();

            //home test cases           
            HomeTestCases home = new HomeTestCases(driver);
            home.HomeTestCases1();

            // creat new cases
            CreatTMTestCases create = new CreatTMTestCases(driver);
            create.CreateTimeAndMaterials();

            //validation(after save)
            Validations val = new Validations(driver);
            val.ValidateTimeMaterial("aisha shaik", true, false);

            //   edit test cases
            EditTestCases edit = new EditTestCases(driver);
            edit.EditTimeAndMaterials();

            // delete test cases
            DeleteTestCases delete = new DeleteTestCases(driver);
            delete.DeleteTimeAndMaterials();

           Console.Read();


        }
    }
}
