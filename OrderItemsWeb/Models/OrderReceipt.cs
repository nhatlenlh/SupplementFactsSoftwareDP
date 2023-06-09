//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderItemsWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderReceipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderReceipt()
        {
            this.IncludeOrderProducts = new HashSet<IncludeOrderProduct>();
        }
    
        public string OrderID { get; set; }
        public int TotalOrderPrice { get; set; }
        public int TotalOrderQuantity { get; set; }
        public System.DateTime OrderedDate { get; set; }
        public string Status { get; set; }
        public string AgentID { get; set; }
    
        public virtual Agent Agent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IncludeOrderProduct> IncludeOrderProducts { get; set; }
    }
}
