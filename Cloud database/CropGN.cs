namespace SmartCropSeerNew
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CropGN")]
    public partial class CropGN
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string gNCode { get; set; }

        public int? cropId { get; set; }

        public virtual Crop Crop { get; set; }

        public virtual GNDivition GNDivition { get; set; }
    }
}
