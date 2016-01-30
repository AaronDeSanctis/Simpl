using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.FinanceModel
{
    public class TransactionContainer
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Expense")]
        public int? ExpenseId { get; set; }

        public virtual Expense Expense { get; set; }

    }
}
