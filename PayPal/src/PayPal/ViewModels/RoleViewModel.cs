using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayPal.Models.PeopleModel;

namespace PayPal.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultSalary { get; set; }
        public int DefaultHourlyWage { get; set; }
        public List<TaskViewModel> Tasks { get; set; }

        public RoleViewModel()
        {
            Tasks = new List<TaskViewModel>();
        }
    }
}
