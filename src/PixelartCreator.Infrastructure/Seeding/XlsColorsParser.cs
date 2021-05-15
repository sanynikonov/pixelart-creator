using OfficeOpenXml;
using PixelartCreator.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PixelartCreator.Infrastructure
{
    public class XlsColorsParser
    {
        private readonly string _path;
        private readonly Regex _pattern = new Regex(@"\d+", RegexOptions.Compiled);

        public XlsColorsParser(string path)
        {
            _path = Path.Combine(path, "Colors.xlsx");
        }

        public SeedingData GetAll()
        {
            var fileInfo = new FileInfo(_path);

            using var package = new ExcelPackage(fileInfo);

            var worksheet = package.Workbook.Worksheets.First();

            var blockId = 1;
            var row = 1;

            var colorsList = new List<Color>();
            var blocksList = new List<MinecraftBlock>();

            var nameCell = worksheet.Cells[row, 1].Value;
            var valueCell = worksheet.Cells[row, 3].Value;
            var blocksCell = worksheet.Cells[row, 4].Value;

            while (valueCell != null && !string.IsNullOrEmpty(valueCell.ToString()))
            {
                row++;

                var matches = _pattern.Matches(valueCell.ToString());
                var blocksNames = blocksCell.ToString().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var name = nameCell.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                var blocks = blocksNames.Select(x => new MinecraftBlock
                {
                    ColorId = row,
                    Id = blockId++,
                    Name = x
                });

                var color = new Color
                {
                    Id = row,
                    Name = name,
                    A = 255,
                    R = byte.Parse(matches[0].Value),
                    G = byte.Parse(matches[1].Value),
                    B = byte.Parse(matches[2].Value),
                };

                colorsList.Add(color);
                blocksList.AddRange(blocks);
                
                nameCell = worksheet.Cells[row, 1].Value;
                valueCell = worksheet.Cells[row, 3].Value;
                blocksCell = worksheet.Cells[row, 4].Value;
            }

            var data = new SeedingData
            {
                Blocks = blocksList,
                Colors = colorsList
            };

            return data;
        }
    }
}
