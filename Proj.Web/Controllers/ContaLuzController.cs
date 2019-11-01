using Microsoft.AspNetCore.Mvc;
using Proj.Domain.Entities;
using Proj.Repository.Interfaces;

namespace Proj.Web.Controllers
{
    public class ContaLuzController : Controller
    {
        private IContaLuzRepository contaLuzRepository;
        private IImovelRepository imovelRepository;

        public ContaLuzController(IContaLuzRepository contaLuzRepository, IImovelRepository imovelRepository)
        {
            this.contaLuzRepository = contaLuzRepository;
            this.imovelRepository = imovelRepository;
        }

        public IActionResult Index()
        {
            ViewBag.menorConsumo = contaLuzRepository.GetMenorConsumo();
            ViewBag.maiorConsumo = contaLuzRepository.GetMaiorConsumo();
            return View(contaLuzRepository.GetAll());
        }

        public IActionResult View(int id)
        {
            ViewBag.Imoveis = imovelRepository.GetAll();
            return View(contaLuzRepository.GetByID(id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Imoveis = imovelRepository.GetAll();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(ContaLuz entity)
        {
            entity.imovel = imovelRepository.GetByID(entity.imovel.id);
            contaLuzRepository.Create(entity);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Imoveis = imovelRepository.GetAll();
            return View(contaLuzRepository.GetByID(id));
        }

        [HttpPost]
        public RedirectToActionResult Update(ContaLuz entity)
        {
            entity.imovel = imovelRepository.GetByID(entity.imovel.id);
            contaLuzRepository.Update(entity);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult Delete(int id)
        {
            contaLuzRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
