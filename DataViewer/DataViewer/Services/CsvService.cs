using CsvHelper;
using CsvHelper.Configuration;
using DataViewer.Helpers;
using DataViewer.Models;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace DataViewer.Services
{
    public class CsvService
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CsvService(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public List<Sales> GetSales()
        {
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "Data.csv");
            using var reader = new StreamReader(filePath, Encoding.UTF8);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<SalesMap>();
            var records = csv.GetRecords<Sales>().ToList();
            return records;
        }
    }
}
