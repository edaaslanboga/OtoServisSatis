﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public int MarkaId { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Renk { get; set; }
        [Display(Name ="Fiyatı")]
        public decimal Fiyati { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Modeli { get; set; }
        [StringLength(50), Display(Name = "Kasa Tipi"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string KasaTipi { get; set; }
        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }
        [Display(Name = "Satışta mı?")]
        public bool SatistaMi { get; set; }
        [Display(Name = "Anasayfa?")]
        public bool Anasayfa { get; set; }
        [Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Notlar {  get; set; }
        [StringLength(100)]
        public string? Resim1 { get; set; }
        [StringLength(100)]
        public string? Resim2 { get; set; }
        [StringLength(100)]
        public string? Resim3 { get; set; }
        public virtual Marka? Marka { get; set; } // Araç sınıfı ile Marka sınıfı arasında bağlantı
    }
}
