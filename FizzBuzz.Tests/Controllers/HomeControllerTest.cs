using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using FizzBuzz.Controllers;
using FizzBuzz.Models;

namespace FizzBuzz.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetOutPutVal()
        {
            // Arrange
            HomeController controller = new HomeController();

            GivenValues gv = new GivenValues();
            gv.InputValues = "1";
            // Act
            ViewResult result = controller.GetOutputValues(gv) as ViewResult;
            var resModel = (GivenValues) result.ViewData.Model;
            string[] expectedres = new string[1]{ "Divided 1 by 3, Divided 1 by 5" };
            // Assert
            Assert.AreEqual(expectedres.ToString(), resModel.OutPutValues.ToString());
        }

        [TestMethod]
        public void GetOutPutValInvalid()
        {
            // Arrange
            HomeController controller = new HomeController();

            GivenValues gv = new GivenValues();
            gv.InputValues = "A";
            // Act
            ViewResult result = controller.GetOutputValues(gv) as ViewResult;
            var resModel = (GivenValues)result.ViewData.Model;
            string[] expectedres = new string[1] { "Invalid Item" };
            // Assert
            Assert.AreEqual(expectedres.ToString(), resModel.OutPutValues.ToString());
        }

        [TestMethod]
        public void GetOutPutValFizzBuzz()
        {
            // Arrange
            HomeController controller = new HomeController();

            GivenValues gv = new GivenValues();
            gv.InputValues = "15";
            // Act
            ViewResult result = controller.GetOutputValues(gv) as ViewResult;
            var resModel = (GivenValues)result.ViewData.Model;
            string[] expectedres = new string[1] { "FizzBuzz" };
            // Assert
            Assert.AreEqual(expectedres.ToString(), resModel.OutPutValues.ToString());
        }
    }
}
