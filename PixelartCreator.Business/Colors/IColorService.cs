﻿using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PixelartCreator.Business
{
    public interface IColorService
    {
        Task<Color> GetAsync(int id);
        Task<IEnumerable<int>> GetColorsIdsAsync();
        Task<IEnumerable<ColorLibraryItemModel>> GetColorsLibraryAsync();
    }
}
