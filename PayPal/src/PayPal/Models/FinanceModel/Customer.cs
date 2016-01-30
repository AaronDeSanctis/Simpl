using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.FinanceModel
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime? PurchaseDate { get; set; }
        public bool? IsRegularCustomer { get; set; }
        public double? AmountSpent { get; set; }
        public bool? RespondsToUpselling { get; set; }
        public int? SatisfactionPercent { get; set; }
        public double? AverageReturnValue { get; set; }
    }
}
