﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoServisSatis.Entities
{
    public class Satis : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Araç No")]
        public int AracId { get; set; }
        [Display(Name = "Müşteri No")]
        public int MusteriId { get; set; }
        [Display(Name = "Satış Fiyatı")]
        public decimal SatisFiyati { get; set; }
        [Display(Name = "Satış Tarihi")]
        public DateTime SatisTarihi { get; set; }
        [Display(Name = "Araç No")]
        public virtual Arac? Arac { get; set; }
        [Display(Name = "Müşteri No")]
        public virtual Musteri? Musteri { get; set; }

    }
}
