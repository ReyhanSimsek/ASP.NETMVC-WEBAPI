//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetaDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMERS()
        {
            this.CUSTOMERADDRESS = new HashSet<CUSTOMERADDRESS>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public string SURNAME { get; set; }
        public string PHONE { get; set; }
        public string MAIL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMERADDRESS> CUSTOMERADDRESS { get; set; }
        public virtual CUSTOMERS CUSTOMERS1 { get; set; }
        public virtual CUSTOMERS CUSTOMERS2 { get; set; }
    }
}
