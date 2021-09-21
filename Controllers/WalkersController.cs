using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DogGo.Controllers
{
   
    
    public class WalkersController : Controller
    {
        // GET: api/<WalkersController>
        [HttpGet]
        // GET: Walkers
        public ActionResult Index()
        {
            List<Walker> walkers = _walkerRepo.GetAllWalkers();

            return View(walkers);
        }


        // GET api/<WalkersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WalkersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<WalkersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WalkersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    private readonly IWalkerRepository _walkerRepo;

    // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
    public WalkersController(IWalkerRepository walkerRepository)
    {
        _walkerRepo = walkerRepository;
    }
    }
}
