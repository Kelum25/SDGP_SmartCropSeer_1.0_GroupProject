namespace SmartCropSeerNew
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AgroEcoZone")]
    public partial class AgroEcoZone
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgroEcoZone()
        {
            GNDivitions = new HashSet<GNDivition>();
        }

        [Key]
        [StringLength(50)]
        public string zoneId { get; set; }

        [StringLength(50)]
        public string zoneName { get; set; }

        [StringLength(50)]
        public string districtId { get; set; }

        public virtual District District { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GNDivition> GNDivitions { get; set; }
    }
}
