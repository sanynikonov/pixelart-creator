using PixelartCreator.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PixelartCreator.Presentation.Data
{
    public class PixelartOptions
    {
        [Required]
        [Range(1, 2000)]
        public int Height { get; set; }

        [Required]
        [Range(1, 2000)]
        public int Width { get; set; }

        public SizeUnit Unit { get; set; }
    }
}
