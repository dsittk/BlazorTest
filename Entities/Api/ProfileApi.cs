using System;
using System.Collections.Generic;
using Entities.Enums;

namespace Entities
{
    public class ProfileApi
    {
        public ProfileApi()
        {
            this.Rights = new List<Rights>();
        }

        public Guid Id { get; set; }
        public IEnumerable<Rights> Rights { get; set; }
    }
}