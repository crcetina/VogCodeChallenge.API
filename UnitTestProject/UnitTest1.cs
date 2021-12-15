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
    }
}