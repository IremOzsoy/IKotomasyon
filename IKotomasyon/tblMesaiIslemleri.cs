//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IKotomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblMesaiIslemleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMesaiIslemleri()
        {
            this.tblMaasIslemleris = new HashSet<tblMaasIslemleri>();
        }
    
        public int mesaiID { get; set; }
        public int personelID { get; set; }
        public Nullable<System.DateTime> mesaiTarihi { get; set; }
        public Nullable<System.DateTime> girisSaati { get; set; }
        public Nullable<System.DateTime> cikisSaati { get; set; }
        public Nullable<double> gunlukMesai { get; set; }
        public Nullable<double> fazlaMesai { get; set; }
        public Nullable<double> eksikMesai { get; set; }
        public Nullable<double> mesaiDonemi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMaasIslemleri> tblMaasIslemleris { get; set; }
        public virtual tblPersonelIslemleri tblPersonelIslemleri { get; set; }
    }
}
