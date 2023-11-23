using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Kitap
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap Adı Boş Bırakılamaz!!")]
        public string KitapAdi { get; set; }

        [Required(ErrorMessage = "Kitap Tanımı Boş Bırakılamaz!!")]
        public string Tanim {  get; set; }
        [Required(ErrorMessage = "Kitap Yazarı Boş Bırakılamaz!!")]
        public string Yazar { get; set;}

        [Required(ErrorMessage = "Lütfen Kitap Fiyatını Girin!!")]
        [Range(10, 10000, ErrorMessage = "Kitap fiyatı 10 ile 10000 arasında olmalıdır.")]
        public double Fiyat {  get; set; }

        [ValidateNever]
        public int KitapTuruId {  get; set; }
        [ForeignKey("KitapTuruId")]
       
        [ValidateNever]

        public KitapTuru KitapTuru { get; set;}

        [ValidateNever]
        public string ResimUrl { get; set; }
    }
}
