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
    
    public partial class BenutzerProfil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenutzerProfil()
        {
            this.LagerSystem = new HashSet<LagerSystem>();
        }
    
        public int NutzerNr { get; set; }
        public string NutzerName { get; set; }
        public string hash { get; set; }
        public string salt { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LagerSystem> LagerSystem { get; set; }
    }
}