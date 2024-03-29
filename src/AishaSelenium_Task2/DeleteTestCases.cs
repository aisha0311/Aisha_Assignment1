﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace AishaSelenium_Task2
{
    internal class DeleteTestCases //class
    {
        private IWebDriver driver; //constructor

        public DeleteTestCases(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Test]
        public void DeleteTimeAndMaterials() //method
        {
            string code = "112233";
            // find the row with this code and delete the row

            Validations val = new Validations(driver);

            val.ValidateTimeMaterial("112233", false, true);

            bool isFound = val.ValidateTimeMaterial("112233", false, false);

            Assert.AreEqual(false, isFound);

        
        }
        //tst
    }
}