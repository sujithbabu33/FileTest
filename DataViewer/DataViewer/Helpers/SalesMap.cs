using CsvHelper.Configuration;
using DataViewer.Models;

namespace DataViewer.Helpers
{
    public class SalesMap: ClassMap<Sales>
    {
        public SalesMap()
        {
            Map(m => m.Segment);
            Map(m => m.Country);
            Map(m => m.Product).Name(" Product ");
            Map(m => m.Discount).Name(" Discount Band ");
            Map(m => m.UnitsSold).Name("Units Sold");
            Map(m => m.ManufacturingPrice).TypeConverter<CurrencyConverter>().Name("Manufacturing Price");
            Map(m => m.SalePrice).TypeConverter<CurrencyConverter>().Name("Sale Price");
            Map(m => m.Date);
        }
    }
}
