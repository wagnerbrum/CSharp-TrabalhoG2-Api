using Microsoft.AspNetCore.Mvc;
using Proj.Domain.Entities;
using Proj.Repository.Interfaces;

namespace Proj.Web.Controllers
{
    public class ImovelController : Controller
    {
        private IImovelRepository imovelRepository;

        public ImovelController(IImovelRepository imovelRepository)
        {
            this.imovelRepository = imovelRepository;
        }

        public IActionResult Index()
        {
            return View(imovelRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            return View(imovelRepository.GetByID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Imovel entity)
        {
            imovelRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(imovelRepository.GetByID(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(Imovel entity)
        {
            imovelRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            imovelRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
