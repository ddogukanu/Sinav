using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySinav
{
    [Table("tblSoru")]
   public class Soru
    {
        [Key]
        public int SoruID { get; set; }
        [Column("Soru")]
        [Required(ErrorMessage ="Soru boş bırakılamaz")]
        public string SoruCumlesi { get; set; }
        [Required(ErrorMessage ="Cevap boş bırakılamaz")]
        public string Cevap { get; set; }
        public string Konu { get; set; }
    }
}
