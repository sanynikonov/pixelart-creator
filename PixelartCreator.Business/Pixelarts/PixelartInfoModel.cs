using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public class PixelartInfoModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string SourcePath { get; set; }
        public string ResultPath { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
    }
}
