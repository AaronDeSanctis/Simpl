using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.PeopleModel
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Role")]
        public int? RoleID { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double? Salary { get; set; }
        public double? Hourly { get; set; }
        public virtual Role Role { get; set; }
        //private ApplicationDbContext _context;
        //private UserManager<ApplicationUser> _userManager;
        //IEnumerable<Employee> employees = _context.Employee.Where(p => p.Id == Id).Include(s => s.Role);
    }
}
