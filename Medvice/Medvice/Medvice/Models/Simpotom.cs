using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medvice.Models
{
    public class Simpotom
    {
        public Simpotom()
        {
            Diseases = new List<Disease>();
        }
        [Key]
        public string SimpotomId { get; set; }

        [Column, Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Column, Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public virtual List<Disease> Diseases { get; set; }
    }
}
