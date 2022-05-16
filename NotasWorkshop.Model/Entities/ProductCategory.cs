using NotasWorkshop.Core.BaseModel.BaseEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NotasWorkshop.Model.Entities
{
    public class ProductCategory :  BaseEntity
    {
        [Key]
        public int ProductCategoryId { get; set; }
        [JsonIgnore]
        //Foreing Key
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }
}
