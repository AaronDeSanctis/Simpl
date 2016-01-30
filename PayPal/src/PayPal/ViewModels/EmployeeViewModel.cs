using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        [ForeignKey("RoleID")]
        public int RoleID { get; set; }
        public int Salary { get; set; }
        public int Hourly { get; set; }
        public string DisplayName { get; set; }
        public RoleViewModel Role { get; set; }
    }
}
