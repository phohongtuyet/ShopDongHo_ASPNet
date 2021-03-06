//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopDongHo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    public partial class DongHo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DongHo()
        {
            this.DatHang_ChiTiet = new HashSet<DatHang_ChiTiet>();
        }
        [Display(Name = "Mã đồng hồ")]
        public int ID { get; set; }

        [Display(Name = "Thương hiệu")]
        [Required(ErrorMessage = "Chưa chọn thương hiệu!")]
        public Nullable<int> ThuongHieu_ID { get; set; }

        [Display(Name = "Loại đồng hồ")]
        [Required(ErrorMessage = "Chưa chọn loại đồng hồ!")]
        public Nullable<int> TenLoai_ID { get; set; }

        [Display(Name = "Chất liệu đồng hồ")]
        [Required(ErrorMessage = "Chưa chọn Chất liệu đồng hồ!")]
        public Nullable<int> ChatLieu_ID { get; set; }

        [Display(Name = "Xuất xứ")]
        [Required(ErrorMessage = "Chưa chọn xuất xứ đồng hồ!")]
        public Nullable<int> XuatXu_ID { get; set; }

        [Display(Name = "Tên đồng hồ")]
        [Required(ErrorMessage = "Tên đồng hồ không được bỏ trống!")]
        public string TenDongHo { get; set; }

        [Display(Name = "Màu sắc")]
        [Required(ErrorMessage = "Màu sắc không được bỏ trống!")]
        public string MauSac { get; set; }

        [Display(Name = "Hạn bảo hành (tháng)")]
        [Required(ErrorMessage = "Hạn bảo hành không được bỏ trống!")]
        public Nullable<int> HanBaoHanh { get; set; }

        [Display(Name = "Đơn giá")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public Nullable<int> DonGia { get; set; }

        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Số lượng không được bỏ trống!")]
        public Nullable<int> SoLuong { get; set; }

        [Display(Name = "Hình ảnh đồng hồ")]
        public string HinhAnhDH { get; set; }

        [Display(Name = "Hình ảnh bìa")]
        public HttpPostedFileBase DuLieuHinhAnhDH { get; set; }

        [Display(Name = "Mô tả")]
        [DataType(DataType.MultilineText)]
        public string MoTa { get; set; }
    
        public virtual ChatLieu ChatLieu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatHang_ChiTiet> DatHang_ChiTiet { get; set; }
        public virtual LoaiDH LoaiDH { get; set; }
        public virtual ThuongHieu ThuongHieu { get; set; }
        public virtual XuatXu XuatXu { get; set; }
    }
}
