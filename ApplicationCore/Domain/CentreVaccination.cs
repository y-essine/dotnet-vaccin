using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class CentreVaccination
    {
        [Key]
        public int Id { get; set; }
        public int Capacite { get; set; }
        public int NbChaises { get; set; }
        public int NumTel { get; set; }
        public string ResponsableCentre { get; set; }
        public virtual ICollection<Vaccin> Vaccins { get; set; }
    }
}
