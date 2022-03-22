using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyMutualFundNAVMicroservice.Models
{
    public class MutualFundDBContext: DbContext
    {
        public MutualFundDBContext(DbContextOptions<MutualFundDBContext> options): base(options)
        { 
        
        }
        
        public DbSet<MutualFundPriceDetails> MutualFundPriceDetails { get; set;}
        
        
    }
}
