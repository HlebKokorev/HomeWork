﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2.Tests
{
    [TestClass()]
    public class NumberTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "SystemBase is out of range 2-20")]
        [DataRow(20, -4)]
        [DataRow(20, -4)]
        [DataRow(20, 1)]
        [DataRow(20, 21)]
        public void ConvertToAnotherBaseTestCorrectInput(int number10, int systemBase)
        {
            string actual;
            Number number = new Number(number10, systemBase);
            actual = number.ConvertToAnotherBase();
        }
        [TestMethod()]
        [DataRow(20, 2, "10100")]
        [DataRow(-20, 2, "-10100")]
        public void ConvertToAnotherBaseTestCorrectCalculatingForInt(int number10, int systemBase, string expected)
        {
            string actual;
            Number number = new Number(number10, systemBase);
            actual = number.ConvertToAnotherBase();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [DataRow("20", 2, "10100")]
        [DataRow("-20", 2, "-10100")]
        public void ConvertToAnotherBaseTestCorrectCalculatingForString(string number10, int systemBase, string expected)
        {
            string actual;
            Number number = new Number(number10, systemBase);
            actual = number.ConvertToAnotherBase();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException), "This object is null")]
        public void ConvertToAnotherBaseTestNullObjectInput()
        {
            string actual;
            Number number = null;
            actual = number.ConvertToAnotherBase();
        }
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "One or more arguments are null")]
        public void ConvertToAnotherBaseTestNullStringInput()
        {
            string actual;
            Number number = new Number(null,5);
            actual = number.ConvertToAnotherBase();
        }
    }
}