using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DailyMutualFundNAVMicroservice.Models;
using DailyMutualFundNAVMicroservice.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DailyMutualFundNAVMicroservice.Repository
{
    public class MutualFundRepository : IMutualFundRepository
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MutualFundRepository));
        private readonly MutualFundDBContext _context;

        public MutualFundRepository (MutualFundDBContext context)
        {
            _context = context;
        }



        /// <summary>
        ///  This will return the MutualFund Details by name
        /// </summary>
        /// <param name="mutualFundName"></param>
        /// <returns></returns>
        public MutualFundPriceDetails GetMutualFundByNameRepository(string mutualFundName)
        {
            MutualFundPriceDetails mutualFundData = null;
            try
            {
                string mutualfundName = mutualFundName;
                _log4net.Info("In MutualFundRepository, MutualFundProvider has Called GetMutualFundByNameRepository and " + mutualFundName + " is searched");
                mutualFundData = _context.MutualFundPriceDetails.Where(e => e.MutualFundName == mutualfundName).FirstOrDefault();
                if (mutualFundData != null)
                {
                    var jsonFund = JsonConvert.SerializeObject(mutualFundData);
                    _log4net.Info("Mutual Fund Found " + jsonFund);
                }
                else
                {
                    _log4net.Info("In MutualFundRepository, MutualFund " + mutualFundName + " is not found.");
                }
            }
            catch (Exception exception)
            {
                _log4net.Error("Exception occurred while finding the mutual fund details " + exception.Message);
                
            }
            return mutualFundData;
        }

        public object GetMutualFundsByNameRepository(string v)
        {
            throw new NotImplementedException();
        }
    }
}