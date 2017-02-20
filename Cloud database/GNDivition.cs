namespace SmartCropSeerNew
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GNDivition")]
    public partial class GNDivition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GNDivition()
        {
            CropGNs = new HashSet<CropGN>();
        }

        [Key]
        [StringLength(50)]
        public string gNCode { get; set; }

        [StringLength(50)]
        public string gNName { get; set; }

        [StringLength(50)]
        public string zoneId { get; set; }

        public virtual AgroEcoZone AgroEcoZone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CropGN> CropGNs { get; set; }
    }
}
