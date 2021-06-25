using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class FirmaHarukontor
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("FirmaID")]
        public virtual Firma Firma { get; set; }
        public string Nimi { get; set; }
        public string Address { get; set; }
        public string KontaktIsik { get; set; }
        public int KontaktTelefon { get; set; }
        public string Email { get; set; }
        public string Kommentaar { get; set; }

        public ICollection<AsjadeLaenutus> AsjadeLaenutus { get; set; }
    }
}
