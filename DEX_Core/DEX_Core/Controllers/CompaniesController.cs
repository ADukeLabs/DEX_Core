using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DEX_Core_WebAPI.Repositories;
using AutoMapper;
using DEX_Core_WebAPI.ViewModels;
using DEX_Core_WebAPI.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DEX_Core_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompaniesRepository _companiesRepository;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;
        

        public CompaniesController(ICompaniesRepository repository, IMapper mapper, LinkGenerator linkGenerator)
        {
            _companiesRepository = repository;
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompanies(int inputID)
        {            
            var companies = await _companiesRepository.GetAllCompaniesAsync(inputID);
            return Ok(_mapper.Map<CompanyViewModel[]>(companies));
        }

        //    // GET api/values/5
        //    [HttpGet("{id}")]
        //    public string GetCompany(int id)
        //    {
        //        return "value";
        //    }


        // POST api/values
        [HttpPost]
        public async Task<ActionResult<CompanyViewModel>> CreateCompany(CompanyViewModel companyViewModel)
        {

            
            var company = _mapper.Map<Company>(companyViewModel);
            var location = _linkGenerator.GetPathByAction("Get", "Companies", new { inputID = company });
            if (string.IsNullOrWhiteSpace(location))
            {
                return BadRequest("String cannot be null or contain spaces");
            }
            _companiesRepository.Add(company);
            if (await _companiesRepository.SaveAllChangesAsync())
            {
                return Created($"/api/companies/{company.Id}", _mapper.Map<CompanyViewModel>(company));
            }
            return Ok();
        }

        //    // PUT api/values/5
        //    [HttpPut("{id}")]
        //    public void Put(int id, [FromBody]string value)
        //    {
        //    }

        //    // DELETE api/values/5
        //    [HttpDelete("{id}")]
        //    public void Delete(int id)
        //    {
        //    }
    }
}
