﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace websiteBALO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    public partial class CHITIETDONHANG
    {
        [Display(Name = "Mã đơn hàng")]

        public int madonhang { get; set; }
        [Display(Name = "Mã balo")]

        public int Mabalo { get; set; }
        [Display(Name = "Số lượng")]

        public Nullable<int> soluong { get; set; }
        [Display(Name = "đơn giá")]

        public string dongia { get; set; }

        public virtual DONHANG DONHANG { get; set; }
        public virtual DONHANG DONHANG1 { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
