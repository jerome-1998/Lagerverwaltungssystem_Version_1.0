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
    
    public partial class Lieferer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lieferer()
        {
            this.Wareneingang = new HashSet<Wareneingang>();
            this.LagerSystem = new HashSet<LagerSystem>();
            this.Produkte = new HashSet<Produkte>();
        }
    
        public int LiefererNR { get; set; }
        public string LiefererName { get; set; }
        public string PLZ { get; set; }
        public string Adresse { get; set; }
        public string Ort { get; set; }
        public string Telefonnummer { get; set; }
        public string EmailaddresseBetrieb { get; set; }
        public string Website { get; set; }
        public Nullable<int> Ansprechpartner { get; set; }
    
        public virtual LAnsprechpartner LAnsprechpartner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wareneingang> Wareneingang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LagerSystem> LagerSystem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produkte> Produkte { get; set; }
    }
}
