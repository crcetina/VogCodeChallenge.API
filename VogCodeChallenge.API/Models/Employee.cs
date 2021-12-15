using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Employee
    {

        [Key]
        public int Id_Employee { get; set; }
        public int Id_Department { get; set; }
        public string First_name { get; set; }
        public string Last_Name { get; set; }

        public string Job_Title { get; set; }

        public string Street { get; set; }
    }
}
