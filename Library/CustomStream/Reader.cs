using System.Text;
using System.IO;

namespace Gesk.Library.CustomStream
{
    public class Reader
    {
        public static string ReadAllDocument(string path, Encoding encoding)
        {
            string document = null;

            using (StreamReader sr = new StreamReader(path, encoding))
            {
                document = sr.ReadToEnd();
            }

            return document;
        }
    }
}
