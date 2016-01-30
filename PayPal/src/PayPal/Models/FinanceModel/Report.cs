using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.FinanceModel
{
    public abstract class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public double Return { get; set; }
        public bool IsGain { get; set; }
        public double EstimatedCustomerAmount { get; set; }
        public DateTime Date { get; set; }
    }
}
