using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.PeopleModel
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey ("Role")]
        public int RoleID { get; set; }

        public string Name { get; set; }
        public int DifficultyLevel { get; set; }
        public TimeSpan CompletionTime { get; set; }
        public int ValueLevel { get; set; }

        public virtual Role Role { get; set; }
    }
}
