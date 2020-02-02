﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrettyAPI;
using PrettyAPI.Controllers;

namespace PrettyAPI.Tests.Controllers
{
    [TestClass]
    public class ClubsControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ClubsController controller = new ClubsController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("value1", result.ElementAt(0));
            Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ClubsController controller = new ClubsController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Arrange
            ClubsController controller = new ClubsController();

            // Act
            controller.Post("value");

            // Assert
        }

        [TestMethod]
        public void Put()
        {
            // Arrange
            ClubsController controller = new ClubsController();

            // Act
            controller.Put(5, "value");

            // Assert
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            ClubsController controller = new ClubsController();

            // Act
            controller.Delete(5);

            // Assert
        }
    }
}