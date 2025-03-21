﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Musteri : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Display(Name = "Adı"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Adi { get; set; }
        [StringLength(50)]
        [Display(Name = "Soyadı"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Soyadi { get; set; }
        [StringLength(11)]
        [Display(Name = "TC Numarası"), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string? TcNo { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} boş bırakılamaz!")]
        public string Email { get; set; }
        [StringLength(500)]
        public string? Adres { get; set; }
        [StringLength(50)]
        public string? Telefon { get; set; }
        public string? Notlar { get; set; }
        [Display(Name = "Araç")]
        public int AracId { get; set; }
        [Display(Name = "Araç")]
        public virtual Arac? Arac { get; set; }
    }
}
