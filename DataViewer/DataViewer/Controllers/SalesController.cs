using DataViewer.Services;
using Microsoft.AspNetCore.Mvc;

namespace DataViewer.Controllers
{
    public class SalesController: Controller
    {
        private readonly CsvService _csvService;

        public SalesController(CsvService csvService)
        {
            _csvService = csvService;
        }

        public IActionResult Index()
        {
            var sales = _csvService.GetSales();
            return View(sales);
        }
    }
}
