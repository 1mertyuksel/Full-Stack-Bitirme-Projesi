// Data/KullaniciTestSonuc.cs
using System.ComponentModel.DataAnnotations;

namespace PROJEM.Data
{
    public class KullaniciTestSonuc
    {
        public int ID { get; set; }
        public int SoruID { get; set; }
        public string KullaniciID { get; set; }
        public string VerilenCevap { get; set; }
    }
}
