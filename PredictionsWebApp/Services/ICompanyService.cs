using PredictionsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PredictionsWebApp.Services
{
    public interface ICompanyService
    {
     Task<List<Company>> GetCompanies();
    }
}
