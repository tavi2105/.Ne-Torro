using PredictionsWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PredictionsWebApp.Services
{
    public interface ICompanyService
    {
     Task<List<Company>> GetCompanies();
    }
}
