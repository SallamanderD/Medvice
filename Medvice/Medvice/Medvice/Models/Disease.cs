using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Medvice.Models
{
    public class Disease
    {
        public Disease()
        {
            Simpotoms = new List<Simpotom>();
            Medicines = new List<Medicine>();
        }

        [Key]
        public string DiseaseId { get; set; }

        [Column, Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Column, Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public virtual List<Simpotom> Simpotoms { get; set; }
        public virtual List<Medicine> Medicines { get; set; }
    }
} 