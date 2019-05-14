using System;
using System.IO;
using Aspose.Words;
using Aspose.Words.Fonts;

namespace Hello {
    class Program {

        static void SetFont() {
            FontSettings.DefaultInstance.SetFontsFolders(new[] {
                "/Users/wk/Library/Fonts",
                "/System/Library/Fonts",
                "/Applications/Microsoft Word.app/Contents/Resources/DFonts"
            }, false);
        }

        static void Main(string[] args) {

            //SetFont();


            var dataDir = "resource";
            var input = Path.Combine(dataDir, "B.docx");
            var output = Path.Combine(dataDir, "B.pdf");

            var document = new Document(input);



            //FontSettings fontSettings = new FontSettings();
            //fontSettings.FallbackSettings.Load(dataDir + "Fallback.xml");

            // Set font settings
            //doc.FontSettings = fontSettings;


            document.Save(output, SaveFormat.Pdf);
        }
    }
}
