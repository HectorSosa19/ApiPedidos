using NotasWorkshop.Core.BaseModel.BaseEntityDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Model.Entities
{
    public class ProductDto : BaseEntityDto
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
    }
}
