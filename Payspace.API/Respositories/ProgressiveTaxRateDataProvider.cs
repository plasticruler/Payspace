﻿using Payspace.API.Models;
using Payspace.Domain;
using Payspace.Domain.Interface;
using System.Collections.Generic;

namespace Payspace.API.Respositories
{
    public class ProgressiveTaxRateDataProvider : IProgressiveTaxRateDataProvider
    {
        private readonly AppDbContext _dbContext;

        public ProgressiveTaxRateDataProvider(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<ProgressiveTaxRate> TaxRates => _dbContext.ProgressiveTaxRates;
    }
}
