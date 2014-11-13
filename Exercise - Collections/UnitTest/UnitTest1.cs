using System;
using Exercise___Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        #region Test -> CatalogList

        CatalogList<Student> studentCatalogList = new CatalogList<Student>();
        Student s1 = new Student(10);

        [TestMethod]
        public void TestCatalogAdd()
        {
            try
            {
                studentCatalogList.Add(s1);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
           

        }

        [TestMethod]
        public void TestCatalogFind()
        {
            studentCatalogList.Add(s1);
            Assert.AreEqual(10, studentCatalogList.Find(10).Id);
        }

        [TestMethod]
        public void TestCatalogGetAll()
        {
            try
            {
                studentCatalogList.GetAll();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCatalogToString()
        {
            try
            {
                studentCatalogList.ToString();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCatalogCount()
        {
            try
            {
                studentCatalogList.Count();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
        #endregion Test -> CatalogList
        #region Test -> CatalogSet

        private int id =0;
        CatalogSet<int, Student> studentCatalogSet = new CatalogList<int, Student>();
        Student s1 = new Student(10);

        [TestMethod]
        public void TestCatalogAdd()
        {
            try
            {
                studentCatalogList.Add(s1);
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }


        }

        [TestMethod]
        public void TestCatalogFind()
        {
            studentCatalogList.Add(s1);
            Assert.AreEqual(10, studentCatalogList.Find(10).Id);
        }

        [TestMethod]
        public void TestCatalogGetAll()
        {
            try
            {
                studentCatalogList.GetAll();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCatalogToString()
        {
            try
            {
                studentCatalogList.ToString();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCatalogCount()
        {
            try
            {
                studentCatalogList.Count();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
        }
        #endregion Test -> CatalogSet
    }
}
