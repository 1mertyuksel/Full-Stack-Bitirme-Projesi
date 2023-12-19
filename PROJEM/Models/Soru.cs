// Models/Soru.cs
using System.Collections.Generic;

namespace PROJEM.Models
{
    public class Soru
    {
        public int ID { get; set; }
        public string? SoruMetni { get; set; }
        public List<SecenekModel>? Secenekler { get; set; }
        public string? DogruCevap { get; set; }
    }

    public class SecenekModel
    {
        public string? SecenekID { get; set; }
        public string? SecenekMetni { get; set; }
    }
}