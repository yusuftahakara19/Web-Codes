using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.Business.Interfaces;
using Udemy.TodoAppNTier.Dtos.WorkDtos;

namespace Udemy.ToDoAppNTier.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWorkService _workService;
        public HomeController(IWorkService workService, IMapper mapper)
        {
            _workService = workService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _workService.GetAll();
            return View(response.Data);
        }
        
        public IActionResult Create() {
            return View(new WorkCreateDto());
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCreateDto dto)
        {
            if (ModelState.IsValid)
            {
                await _workService.Create(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        public async Task<IActionResult> Update(int id)
        {
            var response = await _workService.GetById<WorkUpdateDto>(id);
            
            return View(response.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WorkUpdateDto dto)
        {
            if (ModelState.IsValid)
            {
                await _workService.Update(dto);
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        public async Task<IActionResult> Remove(int id)
        {
            await _workService.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
