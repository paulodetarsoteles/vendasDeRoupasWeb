using AmabilisWeb.Repositories.Interfaces;
using AmabilisWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AmabilisWeb.Controllers
{
    public class RoupaController : Controller
    {
        private readonly IRoupaRepository _roupaRepository;

        public RoupaController(IRoupaRepository roupaRepository)
        {
            this._roupaRepository = roupaRepository;
        }

        public IActionResult List()
        {
            ViewData["Titulo"] = "Todas as Roupas"; 
            //var roupas = _roupaRepository.Roupas;
            //var totalRoupas = roupas.Count(); 
            var roupaListViewModel = new RoupaListViewModel();
            roupaListViewModel.Roupas = _roupaRepository.Roupas;
            roupaListViewModel.CategoriaAtual = "CA"; 

            return View(roupaListViewModel);
        }
    }
}