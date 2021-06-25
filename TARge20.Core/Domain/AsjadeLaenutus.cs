using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class AsjadeLaenutus
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("FirmaID")]
        public virtual Firma Firma { get; set; }
        [ForeignKey("TöötajaID")]
        public virtual Töötaja Töötaja { get; set; }
        public string AsjaNimi { get; set; }
        public string AsjaKirjeldus { get; set; }
        public int Kogus { get; set; }
        public DateTime LaenutuseAlgus { get; set; }
        public DateTime LaenutuseLõpp { get; set; }
        public string Kommentaar { get; set; }
    }
}
