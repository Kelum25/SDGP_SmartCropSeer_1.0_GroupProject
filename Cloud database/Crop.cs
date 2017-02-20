namespace SmartCropSeerNew
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Crop")]
    public partial class Crop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cropId { get; set; }

        [StringLength(50)]
        public string cropName { get; set; }

        [StringLength(50)]
        public string season { get; set; }

        [StringLength(50)]
        public string group { get; set; }

        [StringLength(50)]
        public string waterSource { get; set; }

        [Column(TypeName = "image")]
        public byte[] cropImage { get; set; }

        [StringLength(50)]
        public string moisure { get; set; }

        [StringLength(50)]
        public string humidity { get; set; }

        [StringLength(50)]
        public string temperature { get; set; }

        public int? phValue { get; set; }

        public virtual Ph Ph { get; set; }

        public virtual CropGN CropGN { get; set; }
    }
}
