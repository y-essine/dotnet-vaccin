using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public enum TypeVaccin
    {
        Pfizer,
        Moderna,
        Johnson
    }

    public class Vaccin
    {
        [Key]
        public int Id { get; set; }
        public int Quantite { get; set; }
        public string Fournisseur { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateValidite { get; set; }
        public TypeVaccin Type { get; set; }
        public virtual CentreVaccination CentreVaccination { get; set; }
        public int CentreVaccinationId { get; set; }
    }
}
