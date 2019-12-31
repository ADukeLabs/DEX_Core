using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DEX_Core_WebAPI.Repositories;
using AutoMapper;
using DEX_Core_WebAPI.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DEX_Core_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesRepository _companiesRepository;
        private readonly IMapper _mapper;

        public CompaniesController(ICompaniesRepository repository, IMapper mapper)
        {
            _companiesRepository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanies()
        {
            var companies = await _companiesRepository.GetAllCompaniesAsync();
            return Ok(_mapper.Map<CompanyViewModel[]>(companies));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string GetCompany(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
