using ConsoleApp;
using NUnit.Framework;
using VogCodeChallenge.API.Business;

namespace UnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ManagmentEmployees mng = new ManagmentEmployees();
            Assert.IsNotNull(mng.GetAll());
            Assert.IsNotNull(mng.ListAll());
            Assert.IsNotNull(mng.list_Employees());
            Assert.IsNotNull(mng.list_Departments());
            Assert.IsNotNull(mng.list_Departments_Filter(1));
            Assert.IsNotNull(mng.list_Departments_Filter(2));
            Assert.IsNotNull(mng.list_Departments_Filter(3));
        }

        [Test]
        public void TESTModule1()
        {
            TEST mng = new TEST();
            Assert.AreEqual("2",mng.TESTModule(1));
            Assert.AreEqual("4", mng.TESTModule(2));
            Assert.AreEqual("6", mng.TESTModule(3));
            Assert.AreEqual("8", mng.TESTModule(4));
            Assert.AreEqual("15", mng.TESTModule(5));
            Assert.AreEqual("Error: you cannot perform operations with the value less than 1", mng.TESTModule(0));
            Assert.AreEqual("3.0f", mng.TESTModule(1.0f));
            Assert.AreEqual("3.0f", mng.TESTModule(2.0f));
            Assert.AreEqual("", mng.TESTModule(5.0f));
            Assert.AreEqual("CARLOS", mng.TESTModule("carlos"));
            Assert.AreEqual("True", mng.TESTModule(true));
        }
    }
}