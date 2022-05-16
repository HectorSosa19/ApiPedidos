using NotasWorkshop.Core.BaseModel.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasWorkshop.Model.Entities
{
    public class GenerateToken
    {
        public string Token { get; set; } = String.Empty;
        public string RefreshToken { get; set; } = String.Empty ;
    }
}
