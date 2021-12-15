using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Models
{
    public class Departments : Company
    {
        [Key]
        public int Id_Department { get; set; }
        public string Name_Department { get; set; }
        public string Address_Department { get; set; }
        public List<Employee> Employees { get; set; }

    }
}
