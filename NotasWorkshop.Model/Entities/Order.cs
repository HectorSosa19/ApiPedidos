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
    public class Order : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [JsonIgnore]
        public int UserId { get; set; }
        public User Users { get; set; }
        public int Total { get; set; }
        public DateTime Date { get; set; }
    }
}
