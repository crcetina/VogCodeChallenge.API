using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Business
{
    public class ManagmentEmployees
    {

        public IEnumerable<Employee> GetAll()
        {
            return list_Employees();
        }

        public IList<Employee> ListAll()
        {
            return list_Employees();
        }





        public List<Employee> list_Employees()
        {
            List<Employee> list = new List<Employee>();

            Employee obj = new Employee()
            {
                Id_Employee = 1,
                Id_Department = 1,
                First_name = "Charles",
                Last_Name = "Dawnson",
                Job_Title = "Technical Lead",
                Street = "3408 Roger Street"
            };

            list.Add(obj);

            obj = new Employee()
            {
                Id_Employee = 1,
                Id_Department = 2,
                First_name = "Joseph",
                Last_Name = "Biden",
                Job_Title = "Boss",
                Street = "3123 Eglinton Avenue"
            };

            list.Add(obj);

            obj = new Employee()
            {
                Id_Employee = 1,
                Id_Department = 3,
                First_name = "Leonardo",
                Last_Name = "Harris",
                Job_Title = "Human resources",
                Street = "3312 Orenda Rd"
            };

            list.Add(obj);

            return list;


        }


        public List<Departments> list_Departments_Filter(int id)
        {
            return list_Departments().Where(d => d.Id_Department.Equals(id)).ToList();
        }


        public IList<Departments> list_Departments()
        {
            IList<Departments> list = new List<Departments>();

            Departments obj = new Departments()
            {
                Id = 1,
                Id_Department = 1,
                Name = "Company Test",
                Name_Department = "Sales",
                Address_Department = "2683 rue Saint-Charles",
                Employees = list_Employees().Where(e => e.Id_Department.Equals(1)).ToList(),

            };
            list.Add(obj);
            obj = new Departments()
            {
                Id = 2,
                Id_Department = 2,
                Name = "Company Test",
                Name_Department = "Human Resources",
                Address_Department = "93 1st Ave",
                Employees = list_Employees().Where(e => e.Id_Department.Equals(2)).ToList(),
            };
            list.Add(obj);

            obj = new Departments()
            {
                Id = 3,
                Id_Department = 3,
                Name = "Company Test",
                Name_Department = "shopping",
                Address_Department = "3964 Eagle Rd",
                Employees = list_Employees().Where(e => e.Id_Department.Equals(3)).ToList(),
            };
            list.Add(obj);


            return list;


        }

    }


}
