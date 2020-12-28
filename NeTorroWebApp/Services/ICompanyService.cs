using NeTorroWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NeTorroWebApp.Services
{
    public interface ICompanyService
    {
     Task<List<Company>> GetCompanies();
        Task<Company> GetCompany(int id);
    }
}
