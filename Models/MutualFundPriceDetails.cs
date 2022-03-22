using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAVMicroservice.Models
{
    public class MutualFundPriceDetails
    {
        [Key]
        public int MutualFundId { get; set; }
        public string MutualFundName { get; set; }
        public int MutualFundPrice { get; set; }
    }
}
