using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class AmetiNimetus
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("TöötajaID")]
        public virtual Töötaja Töötaja { get; set; }
        public string Amet { get; set; }
        public DateTime MääramiseAeg { get; set; }
        public string Kommentaar { get; set; }
    }
}
