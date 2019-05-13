using System;
using Aspose.Words;

namespace Hello {
    class Program {
        static void Main(string[] args) {
            var dataDir = "resource/";
            Document doc = new Document(dataDir + "A.docx");

            //FontSettings fontSettings = new FontSettings();
            //fontSettings.FallbackSettings.Load(dataDir + "Fallback.xml");

            // Set font settings
            //doc.FontSettings = fontSettings;
            dataDir = dataDir + "A.pdf";
            doc.Save(dataDir);
        }
    }
}
