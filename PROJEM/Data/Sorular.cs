// Data/Sorular.cs
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PROJEM.Data
{
    public class Soru
    {
        public int ID { get; set; }
        public string? SoruMetni { get; set; }
        public List<SecenekModel>? Secenekler { get; set; }
        public string? DogruCevap { get; set; }

        
        public string? KullaniciCevabi { get; set; }
    }

    public class SecenekModel
    {
        [Key]
        public string? SecenekID { get; set; }
        public string? SecenekMetni { get; set; }
    }
}