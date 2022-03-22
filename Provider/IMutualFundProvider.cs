using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using DailyMutualFundNAVMicroservice.Repository;
using DailyMutualFundNAVMicroservice.Models;

namespace DailyMutualFundNAVMicroservice.Provider
{
    public interface IMutualFundProvider
    {
        public MutualFundPriceDetails GetMutualFundByNameProvider(string mutualFundName);
    }
}
