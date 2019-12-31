using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEX_Core_WebAPI.Models;

namespace DEX_Core_WebAPI.Repositories
{
    public class CompaniesRepository : ICompaniesRepository
    {
        public void Add<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<Company> CreateCompany()
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<Company[]> GetAllCompaniesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
