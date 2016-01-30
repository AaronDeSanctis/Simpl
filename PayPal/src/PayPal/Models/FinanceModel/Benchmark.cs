using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayPal.Models.FinanceModel
{
    public class Benchmark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("ActualReport")]
        public int? ActualReportId { get; set; }

        [ForeignKey("ExpectedReport")]
        public int? ExpectedReportId { get; set; }

        [ForeignKey("BenchmarkContainer")]
        public int? BenchmarkContainerId { get; set; }

        public bool? IsComplete { get; set; }
        public int? CompletionPercent { get; set; }
        public double ShortTermGoal { get; set; }
        public virtual ActualReport ActualReport { get; set; }
        public virtual ExpectedReport ExpectedReport { get; set; }
        public virtual BenchmarkContainer BenchmarkContainer { get; set; }
    }
}
