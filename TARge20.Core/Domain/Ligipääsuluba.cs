using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class Ligipääsuluba
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("TöötajaID")]
        public virtual Töötaja Töötaja { get; set; }
        public Ligipääsuluba LigipääsuLuba { get; set; }
        public DateTime AlgusKuupäev { get; set; }
        public DateTime LõppKuupäev { get; set; }
        public string Kommentaar { get; set; }
    }
}
