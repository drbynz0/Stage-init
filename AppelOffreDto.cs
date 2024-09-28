using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winForms
{
    public class AppelOffreDto
    {
        public string? NumList { get; set; }
        public string? Procedure { get; set; }
        public string? Categorie { get; set; }
        public string? DatePublication { get; set; }
        public string? Reference { get; set; }
        public string? Objet { get; set; }
        public string? Estimation { get; set; }
        public string? Caution { get; set; }
        public string? AcheteurPublic { get; set; }
        public string? LieuExecution { get; set; }
        public string? DateLimite { get; set; }
        public string? HeureLimite { get; set; }
        public string? Telecharger { get { return "Telecharger"; } }
    }


}
