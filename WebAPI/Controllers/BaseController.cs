using DataAccessLayer.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    public class BaseController<T> : Controller
        where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repo;

        public BaseController(IBaseRepository<T> repo)
        {
            _repo = repo;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("ID can't be 0");
            }
            var entity = _repo.Get(id);
            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Post(T entity)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(entity);
            }
            return Ok(entity);
        }

        [HttpPut]
        public async Task<IActionResult> Put(T entity)
        {
            if (ModelState.IsValid)
            {
                _repo.Update(entity);
            }
            return Ok(entity);
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            _repo.Delete(id);
            return Ok();
        }
    }
}
