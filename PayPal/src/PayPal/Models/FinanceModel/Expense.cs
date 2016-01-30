using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.FinanceModel
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("TotalTransactions")]
        public int? TotalTransactionsId { get; set; }

        [ForeignKey("TodaysTransactions")]
        public int? TodaysTransactionsId { get; set; }

        [ForeignKey("FakeTransactions")]
        public int? FakeTransactionsId { get; set; }

        public virtual TotalTransaction TotalTransactions  { get; set; }
        public virtual TodaysTransaction TodaysTransactions { get; set; }
        public virtual FakeTransaction FakeTransactions { get; set; }
    }
}
