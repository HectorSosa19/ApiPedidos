using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NotasWorkshop.Core.BaseModel.BaseDto
{
    public interface IBaseDto
    {
        [JsonIgnore]
        int? Id { get; set; }
        bool Deleted { get; set; }
    }
}
