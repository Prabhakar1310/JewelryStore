using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JewelryStore.BL
{
    public class PrintToFile
    {
        string path;
        public PrintToFile(string path)
        {
            this.path = path;
        }
        public bool Print(string printData)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string fileName = Guid.NewGuid().ToString() + ".txt";
                using (TextWriter txt = new StreamWriter(path + "\\" + fileName))
                {
                    txt.Write(printData);
                    txt.Close();
                }
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
