using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace PixelartCreator.Domain
{
    public class User : IdentityUser<int>, IBaseEntity
    {
        public ICollection<Pixelart> Pixelarts { get; set; }
    }
}
