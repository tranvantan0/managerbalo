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

    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.DONHANGs = new HashSet<DONHANG>();
        }
        [Display(Name = "Mã khách hàng")]
        public int maKH { get; set; }
        [Display(Name = "Họ tên")]
        public string hoten { get; set; }
        [Display(Name = "Tên tài khoản")]
        public string taikhoan { get; set; }
        [Display(Name = "Mật khẩu")]
        public string matkhau { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Địa chỉ")]
        public string diachi { get; set; }
        [Display(Name = "Số điện thoại")]
        public string dienthoai { get; set; }
        [Display(Name = "Giới tính")]
        public string gioitinh { get; set; }
        [Display(Name = "Ngày sinh")]
        public Nullable<System.DateTime> ngaysinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
