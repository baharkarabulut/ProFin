//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProFin
{
    using System;
    using System.Collections.Generic;
    
    public partial class FaturaKalemleri
    {
        public int KalemID { get; set; }
        public Nullable<int> FaturaID { get; set; }
        public string UrunHizmetAdi { get; set; }
        public Nullable<int> Miktar { get; set; }
        public Nullable<decimal> BirimFiyat { get; set; }
        public Nullable<decimal> AraToplam { get; set; }
    
        public virtual Faturalar Faturalar { get; set; }
    }
}