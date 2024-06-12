using CsvHelper.Configuration.Attributes;

namespace DataViewer.Models
{
    public class Sales
    {
        public string Segment { get; set; }
        public string Country { get; set; }
        [Name(" Product ")]
        public string Product { get; set; }
        [Name(" Discount Band ")]
        public string Discount { get; set; }
        [Name("Units Sold")]
        public string UnitsSold { get; set; }
        [Name("Manufacturing Price")]
        public decimal ManufacturingPrice { get; set; }
        [Name("Sale Price")]
        public decimal SalePrice { get; set; }
        public DateTime Date { get; set; }

        public string ManufacturingPriceWithSymbol => $"£{ManufacturingPrice:N2}";
        public string SalePriceWithSymbol => $"£{SalePrice:N2}";
    }
}
