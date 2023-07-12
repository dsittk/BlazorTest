using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTO
{
    public class UserAccessTable
    {
        public IEnumerable<UserAccessSimpleDto>? Access { get; set; }
        public int Total { get; set; }
    }
}
