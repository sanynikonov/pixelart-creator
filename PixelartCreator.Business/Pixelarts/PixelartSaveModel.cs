using System;
using System.Collections.Generic;
using System.Text;

namespace PixelartCreator.Business
{
    public class PixelartSaveModel
    {
        public int UserId { get; set; }
        public string ResultPath { get; set; }
        public string SourcePath { get; set; }
        public string Description { get; set; }
    }
}
