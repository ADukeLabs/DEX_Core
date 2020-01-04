using DEX_Core_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEX_Core_WebAPI.Repositories
{
    public interface ICompaniesRepository
    {
        //General

        Task<Company[]> GetAllCompaniesAsync(int ID);
        Task<Company> CreateCompany();

        //void Add<T>(T entity) where T : class;
        //void Delete<T>(T entity) where T : class;

        
        
        
    }
}
