using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cursovaia
{
    class ToExternalDOC : UploadDataToFiles
    {
        FileStream fileStream = null;
        public override void CreateFile()
        {


            string fileName = "someFile.docx";
            fileName = Path.Combine(Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\"), fileName);
            if (!File.Exists(fileName))
                fileStream = File.Create(fileName); 
            else
            {
                File.Delete(fileName);

                CreateFile();
            }
        }
        public override void DateToFile(House house)
        {

            StreamWriter output = new StreamWriter(fileStream);

            output.Write(house);

            
            output.Close();
        }
    }
}
