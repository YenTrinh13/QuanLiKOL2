//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiKOL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class hopdong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hopdong()
        {
            this.ThoiGianBieuKOLs = new HashSet<ThoiGianBieuKOL>();
        }
    
        public string mahd { get; set; }
        public string tenhd { get; set; }
        public string linhvuc { get; set; }
        public Nullable<decimal> trigia { get; set; }
        public string bena { get; set; }
        public string benb { get; set; }
        public string benc { get; set; }
        public Nullable<System.DateTime> ngaybatdau { get; set; }
        public Nullable<System.DateTime> ngayketthuc { get; set; }
        public string dieukhoan { get; set; }
        public Nullable<int> trangthai { get; set; }
        public string AnhHD { get; set; }
        public Nullable<System.DateTime> ngayyeucau { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual khach khach { get; set; }
        public virtual KOL KOL { get; set; }
        public virtual linhvuc linhvuc1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThoiGianBieuKOL> ThoiGianBieuKOLs { get; set; }
    }
}
