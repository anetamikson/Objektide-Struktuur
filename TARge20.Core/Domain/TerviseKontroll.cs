using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class TerviseKontroll
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("TöötajaID")]
        public virtual Töötaja Töötaja { get; set; }
        public DateTime TervisekontrolliKuupäev { get; set; }
        public string Kommentaar { get; set; }
    }
}
