namespace ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        static void Main(string[] args)
        {
            var reader = new DataReader();
            var path = System.IO.Path.GetDirectoryName(
      System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
            string fileName = "\\data.csv";
            reader.ImportAndPrintData(string.Format("{0}{1}", path, fileName));
        }
    }
}
