using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class Firma
    {
        [Key]
        public Guid Id { get; set; }
        public int RegNumber { get; set; }
        public string Nimi { get; set; }
        public string LühiNimi { get; set; }
        public string Address { get; set; }
        public string Kontaktisik { get; set; }
        public int KOntaktTelefon { get; set; }
        public string Email { get; set; }
        public string Kommentaar { get; set; }

        public ICollection<FirmaHarukontor> FirmaHarukontor { get; set; }
    }
}
