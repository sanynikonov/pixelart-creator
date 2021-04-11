using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            _path = path;
        }

        public IEnumerable<Color> GetAll()
        {
            var fileInfo = new FileInfo(_path);

            using var package = new ExcelPackage(fileInfo);

            var worksheet = package.Workbook.Worksheets.First();

            List<string> colorsStringValues = new List<string>();
            int row = 1;
            int column = 3;
            var value = worksheet.Cells[row++, column].Value;

            while (value != null && !string.IsNullOrEmpty(value.ToString()))
            {
                colorsStringValues.Add(value.ToString());
                value = worksheet.Cells[row++, column].Value;
            }

            return colorsStringValues.Select(s =>
            {
                var matches = _pattern.Matches(s);
                return Color.FromArgb(int.Parse(matches[0].Value), int.Parse(matches[1].Value), int.Parse(matches[2].Value));
            });
        }
    }
}
