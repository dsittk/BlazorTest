using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Api
{
    public class ProfileSimpleApi
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
    }
}
