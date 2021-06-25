using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace TARge20.Core.Domain
{
    public class PuhkuseLiik
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("PuhkusID")]
        public virtual Puhkus Puhkus { get; set; }
        public string PuhkusLiik { get; set; }
        public string Kommentaar { get; set; }
    }
}
