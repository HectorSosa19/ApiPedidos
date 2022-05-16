using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NotasWorkshop.Core.BaseModel.BaseEntityDto
{
    public class BaseEntityDto : BaseDto.BaseDto, IBaseEntityDto
    {
        [JsonIgnore]
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
    }
}
