using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.FinanceModel
{
    public class Goal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("BenchmarkContainer")]
        public int? BenchmarkContainerId { get; set; }

        public double ExpectedTotalDaily { get; set; }
        public double RealisticTotalDaily { get; set; }
        public double YearlyIncome { get; set; }
        public double YearlyGoalIncome { get; set; }
        public double ExpectedCareerLength { get; set; }
        public int? CompletionPercent { get; set; }
        public BenchmarkContainer BenchmarkContainer { get; set; }
    }
}
