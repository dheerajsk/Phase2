using DataAccessLayer.Repositories;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APILayer.Controllers
{
    public class BaseController<T> : Controller
        where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repo;

        public BaseController(IBaseRepository<T> repo)
        {
            _repo = repo;
        }

        // GET: Employee
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        // GET: Employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _repo.Get(id.Value);
            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(T entity)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(entity);
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

        // GET: Employee/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _repo.Get(id.Value);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, T entity)
        {
            if (id != entity.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _repo.Update(entity);
                return RedirectToAction(nameof(Index));
            }
            return View(entity);
        }

        // GET: Employee/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entity = _repo.Get(id.Value);
            if (entity == null)
            {
                return NotFound();
            }

            return View(entity);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
