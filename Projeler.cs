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
    
    public partial class Projeler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projeler()
        {
            this.Faturalar = new HashSet<Faturalar>();
            this.Gorevler = new HashSet<Gorevler>();
            this.Etkilesim = new HashSet<Etkilesim>();
        }
    
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }
        public Nullable<int> MusteriID { get; set; }
        public string Durum { get; set; }
        public Nullable<System.DateTime> BaslangicTarihi { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
        public Nullable<decimal> ToplamTutar { get; set; }
        public string Notlar { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Faturalar> Faturalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gorevler> Gorevler { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Etkilesim> Etkilesim { get; set; }
    }
}
