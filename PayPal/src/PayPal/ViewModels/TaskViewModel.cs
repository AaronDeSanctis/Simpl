using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.ViewModels
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        [ForeignKey("RoleID")]
        public int RoleID { get; set; }
        public int DifficultyLevel { get; set; }
        public TimeSpan CompletionTime { get; set; }
        public int Value { get; set; }
    }
}
