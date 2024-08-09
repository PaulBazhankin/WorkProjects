//Код взят из интернета и проверен на наличие вредоносных частей
//Чтение из Excel Файла выполняется с помощью библиотеки OpenXml

using System;
using System.Linq;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.IO;


namespace ExcelReader
{
    public class Reader : IDisposable
    {
        readonly private Stream file;
        readonly SpreadsheetDocument document;

        public string GetCellValue(string sheetName, string addressName)
        {
            string value = "";
            try
            {
                WorkbookPart wbPart = document.WorkbookPart;
                Sheet theSheet = wbPart.Workbook.Descendants<Sheet>().Where(s => s.Name == sheetName).FirstOrDefault() ?? throw new ArgumentException("sheetName");
                WorksheetPart wsPart = (WorksheetPart)(wbPart.GetPartById(theSheet.Id));
                Cell theCell = wsPart.Worksheet.Descendants<Cell>().Where(c => c.CellReference == addressName).FirstOrDefault();
                if (theCell != null && theCell.InnerText.Length > 0)
                {
                    value = theCell.InnerText;
                    if (theCell.DataType != null)
                    {
                        switch (theCell.DataType.Value)
                        {
                            case CellValues.SharedString:
                                var stringTable = wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();
                                if (stringTable != null)
                                {
                                    value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                                }
                                break;
                            case CellValues.Boolean:
                                switch (value)
                                {
                                    case "0":
                                        value = "FALSE";
                                        break;
                                    default:
                                        value = "TRUE";
                                        break;
                                }
                                break;
                        }
                    }
                }
            } catch
            {
                return null;
            }
            return value;
        }

        public string[] GetSheets()
        {
            string[] sheets;
            WorkbookPart wbPart = document.WorkbookPart;
            List<string> _sheets = new List<string>();
            foreach(Sheet sheet in wbPart.Workbook.Descendants<Sheet>())
            {
                _sheets.Add(sheet.Name);
            }
            sheets = _sheets.ToArray();
            return sheets;
        }
        public Reader(string fileName)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(fileName));
            file = new MemoryStream(br.ReadBytes((int)br.BaseStream.Length));
            br.Close();
            br.Dispose();
            document = SpreadsheetDocument.Open(file, false);
        }

        public void Dispose()
        {
            document.Close();
            document.Dispose();
            file.Close();
            file.Dispose();
        }
    }
}
