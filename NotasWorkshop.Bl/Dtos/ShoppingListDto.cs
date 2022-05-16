using NotasWorkshop.Core.BaseModel.BaseEntityDto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NotasWorkshop.Model.Entities
{
    public class ShoppingListDto : BaseEntityDto
    {
        [Key]
        public int ShoppingListId { get; set; }
        public int Count { get; set; }
        [JsonIgnore]
        //Foreing Key
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
    }
}
