using System.Linq;

namespace DataProcessor.Models
{
    public class WeatherData
    {
        public int Dy { get; set; }
        public int MxT { get; set; }
        public int MnT { get; set; }
        public int AvT { get; set; }
        public int HDDay { get; set; }
        public decimal AvDP { get; set; }
        public int HrP1 { get; set; }
        public decimal TPcpn { get; set; }
        public string WxType { get; set; }
        public int PDir { get; set; }
        public decimal AvSp { get; set; }
        public int Dir { get; set; }
        public int MxS { get; set; }
        public decimal SkyC { get; set; }
        public int MxR { get; set; }
        public int MnR { get; set; }
        public decimal AvSLP { get; set; }

        public override string ToString()
        {
            var elements = GetType()
                .GetProperties()
                .ToList()
                .Select(property => property.GetValue(this));

            var toStringResult = string.Join(", ", elements);

            return toStringResult;
        }
    }
}
