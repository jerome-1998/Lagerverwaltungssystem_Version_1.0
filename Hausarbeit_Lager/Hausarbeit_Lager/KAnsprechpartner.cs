//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hausarbeit_Lager
{
    using System;
    using System.Collections.Generic;
    
    public partial class KAnsprechpartner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KAnsprechpartner()
        {
            this.Kunde = new HashSet<Kunde>();
        }
    
        public int AnsprechPartnerNummer { get; set; }
        public string AnspAnrede { get; set; }
        public string AnspVorname { get; set; }
        public string AnspNachname { get; set; }
        public string AnpsHandyNummer { get; set; }
        public string AnspTelefonnummer { get; set; }
        public string AnspEmail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kunde> Kunde { get; set; }
    }
}
