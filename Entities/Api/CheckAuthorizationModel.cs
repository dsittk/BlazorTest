using System;
using System.Collections.Generic;
using Entities.Enums;

namespace Entities.Api
{
    public class CheckAuthorizationModel
    {
        public CheckAuthorizationModel()
        {
            this.ProfilesId = new List<Guid>();
        }

        public Enums.Rights Right { get; set; }
        public IEnumerable<Guid> ProfilesId { get; set; }
    }
}