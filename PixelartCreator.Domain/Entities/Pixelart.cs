using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Domain
{
    public class Pixelart : IBaseEntity
    {
        public int Id { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }

        public string SourcePath { get; set; }
        public string ResultPath { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
