//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardGame.DAL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DiamantenPack
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DiamantenPack()
        {
            this.tblVirtualPurchase = new HashSet<VirtualPurchase>();
        }
    
        public int ID { get; set; }
        public int PackPrice { get; set; }
        public Nullable<int> Diamanten { get; set; }
        public bool active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VirtualPurchase> tblVirtualPurchase { get; set; }
    }
}
