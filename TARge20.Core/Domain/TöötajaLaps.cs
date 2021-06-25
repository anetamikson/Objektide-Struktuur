using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class TöötajaLaps
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("TöötajaID")]
        public virtual Töötaja Töötaja { get; set; }
        public string Eesnimi { get; set; }
        public string Perekonnanimi { get; set; }
        public DateTime Sünniaasta { get; set; }
        public string Kommentaar { get; set; }
    }
}
