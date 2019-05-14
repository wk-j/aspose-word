using System;
using System.IO;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocToPDFConverter;
using Syncfusion.OfficeChart;
using Syncfusion.Pdf;

namespace Sync {
    class Program {
        static void Main(string[] args) {
            var dataDir = "resource";
            var input = Path.Combine(dataDir, "B.docx");
            var output = Path.Combine(dataDir, "B.pdf");

            var wordDocument = new WordDocument(input, FormatType.Automatic);
            wordDocument.ChartToImageConverter.ScalingMode = ScalingMode.Normal;

            var converter = new DocToPDFConverter();
            var pdfDocument = converter.ConvertToPDF(wordDocument);
            pdfDocument.Save(output);

            pdfDocument.Close();
            wordDocument.Close();
        }
    }
}
