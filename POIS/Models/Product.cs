using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POIS.Models
{
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
        [Bind(Exclude = "Id")]
        public class ProductMetadata
        {
            [ScaffoldColumn(false)]
            public int Id { get; set; }

            [DisplayName("Name")]
            [Required(ErrorMessage ="Product name is required.")]
            [DisplayFormat(ConvertEmptyStringToNull =false)]
            [StringLength(50)]
            public string Name { get; set; }

            [DisplayName("Price")]
            [DisplayFormat(DataFormatString ="{0:F2}",ApplyFormatInEditMode = true)]
            [Required(ErrorMessage = "Product price is required.")]
            [Range(0.01, 999999999,ErrorMessage = "Incorrect price.")]
            public decimal Price { get; set; }

            [DisplayName("Article")]
            [Required(ErrorMessage = "Product article is required.")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(50)]
            public string Article { get; set; }
        }
                
    }
}