using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medvice.Models
{
    public class Medicine
    {
        public Medicine()
        {
            Diseases = new List<Disease>();
        }

        [Key]
        public string MedicineId { get; set; }

        [Column, Required]
        [DataType(DataType.Text)]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "Длина заголовка должна быть от 10 до 100 символов.")]
        public string Name { get; set; }

        [Column, Required]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Column, Required]
        [DataType(DataType.MultilineText)]
        public string Contraindications { get; set; }

        [Column, Required]
        [DataType(DataType.MultilineText)]
        public string Composition { get; set; }

        public virtual List<Disease> Diseases { get; set; }
    }
}