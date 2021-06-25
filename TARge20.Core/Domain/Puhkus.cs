using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class Puhkus
    {
        [Key]
        public Guid Id { get; set; }

        public Töötaja Töötaja { get; set; }
        public DateTime PuhkuseAlgus { get; set; }
        public DateTime PuhkuseLõpp { get; set; }
        public string Kommentaar { get; set; }

        public PuhkuseLiik PuhkuseLiik { get; set; }
    }
}
