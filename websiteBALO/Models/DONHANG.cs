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
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            this.CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            this.CHITIETDONHANGs1 = new HashSet<CHITIETDONHANG>();
        }
        [Display(Name = "Mã đơn hàng")]

        public int madonhang { get; set; }
        [Display(Name = "Thanh toán")]

        public Nullable<int> dathanhtoan { get; set; }
        [Display(Name = "Tình trạng giao hàng")]

        public Nullable<int> tinhtranggiaohang { get; set; }
        [Display(Name = "Ngày đặt")]

        public Nullable<System.DateTime> ngaydat { get; set; }
        [Display(Name = "Ngày giao")]

        public Nullable<System.DateTime> ngaygiao { get; set; }
        [Display(Name = "Mã khách hàng")]

        public Nullable<int> maKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs1 { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
