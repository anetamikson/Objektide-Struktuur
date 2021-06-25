using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    [Table("Töötaja")]
    public class Töötaja
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("FirmaID")]
        public virtual Firma Firma { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public string Isikukood { get; set; }
        public string Address { get; set; }
        public int Kontakttelefon { get; set; }
        public string Email { get; set; }
        public DateTime TöölAlates { get; set; }
        public string TöölKuni { get; set; }
        public string Kommentaar { get; set; }

        public ICollection<TöötajaLaps> TöötajaLaps { get; set; }
        public Ligipääsuluba Ligipääsuluba { get; set; }
        public TerviseKontroll TerviseKontroll { get; set; }
        public ICollection<HaigusLeht> HaigusLeht { get; set; }
        public AmetiNimetus AmetiNimetus { get; set; }
        public ICollection<Puhkus> Puhkus { get; set; }
        public ICollection<AsjadeLaenutus> AsjadeLaenutus { get; set; }
    }
}
