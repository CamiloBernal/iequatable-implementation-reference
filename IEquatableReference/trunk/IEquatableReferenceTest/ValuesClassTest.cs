﻿using System.Globalization;
using System.Linq;
using System.Threading;
using IEquatableReference;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace IEquatableReferenceTest
{


    /// <summary>
    ///This is a test class for ValuesClassTest and is intended
    ///to contain all ValuesClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ValuesClassTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Equals : Properties are equal
        ///</summary>
        [TestMethod()]
        public void EqualsEqualPropertiesTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass()
            };
            var expected = true;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals : First properties are unequal
        ///</summary>
        [TestMethod()]
        public void EqualsUnequalFirstPropertiesTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass() { First = 1 }
            };
            var expected = false;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals : Second properties are unequal
        ///</summary>
        [TestMethod()]
        public void EqualsUnequalSecondPropertiesTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass() { Second = 1d }
            };
            var expected = false;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals : Parameter is null
        ///</summary>
        [TestMethod()]
        public void EqualsEqualsNullTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                null
            };
            var expected = false;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator == : Equality
        ///</summary>
        [TestMethod()]
        public void EqualityOperatorEqualityTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass()
            };
            var expected = true;
            var actual = targets[0] == targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator == : Unequality
        ///</summary>
        [TestMethod()]
        public void EqualityOperatorUnequalityTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass() { First = 1 }
            };
            var expected = false;
            var actual = targets[0] == targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator == : Null equality
        ///</summary>
        [TestMethod()]
        public void EqualityOperatorNullEqualityTest()
        {
            var targets = new ValuesClass[] 
            {
                null
                ,
                null
            };
            var expected = true;
            var actual = targets[0] == targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator == : Null unequality
        ///</summary>
        [TestMethod()]
        public void EqualityOperatorNullUnequalityTest()
        {
            var targets = new ValuesClass[] 
            {
                null
                ,
                new ValuesClass()
            };
            var expected = false;
            var actual = targets[0] == targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator != : Equality
        ///</summary>
        [TestMethod()]
        public void UnequalityOperatorEqualityTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass()
            };
            var expected = false;
            var actual = targets[0] != targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator != : Unequality
        ///</summary>
        [TestMethod()]
        public void UnequalityOperatorUnequalityTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass() { First = 1 }
            };
            var expected = true;
            var actual = targets[0] != targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator != : Null Equality
        ///</summary>
        [TestMethod()]
        public void UnequalityOperatorNullEqualityTest()
        {
            var targets = new ValuesClass[] 
            {
                null
                ,
                null
            };
            var expected = false;
            var actual = targets[0] != targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for operator != : Null unequality
        ///</summary>
        [TestMethod()]
        public void UnequalityOperatorNullUnequalityTest()
        {
            var targets = new ValuesClass[] 
            {
                null
                ,
                new ValuesClass()
            };
            var expected = true;
            var actual = targets[0] != targets[1];
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode : Equality
        ///</summary>
        [TestMethod()]
        public void GetHashCodeEqualityTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass()
            };
            var expected = 1;
            var actual = targets.Distinct().Count();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetHashCode : Unequality
        ///</summary>
        [TestMethod()]
        public void GetHashCodeUnequalityTest()
        {
            var targets = new ValuesClass[] 
            {
                new ValuesClass()
                ,
                new ValuesClass() { First = 1 }
            };
            var expected = 2;
            var actual = targets.Distinct().Count();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals object : Equality
        ///</summary>
        [TestMethod()]
        public void EqualsObjectEqualityTest()
        {
            var targets = new object[] 
            {
                new ValuesClass()
                ,
                new ValuesClass()
            };
            var expected = true;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals object : Properties unequality
        ///</summary>
        [TestMethod()]
        public void EqualsObjectPropertiesUnequalityTest()
        {
            var targets = new object[] 
            {
                new ValuesClass() { First = 1 }
                ,
                new ValuesClass()
            };
            var expected = false;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            var target = new ValuesClass()
            {
                First = 1,
                Second = 5d
            };
            var expected = "{ First = 1, Second = 5 }";
            var actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTestOtherCulture()
        {
            Thread.CurrentThread.CurrentCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = ",";
            var target = new ValuesClass()
            {
                First = 1,
                Second = 2.5d
            };
            var expected = "{ First = 1, Second = 2.5 }";
            var actual = target.ToString();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Equals object : Type unequality
        ///</summary>
        [TestMethod()]
        public void EqualsObjectTypeUnequalityTest()
        {
            var targets = new object[] 
            {
                new ValuesClass()
                ,
                0d
            };
            var expected = false;
            var actual = targets[0].Equals(targets[1]);
            Assert.AreEqual(expected, actual);
        }
    }
}
