using System;
using System.IO;

namespace DeleteAllFilesOlderThen
{
    public class DeleteAllFilesOlderThen
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"\\dub-backup01\SQLBACKUPS\DUB-DRSDBPRD01\FULL\DORIS");
            var now = DateTime.Now;

            foreach(var file in files)
            {
                var ts  = now.Subtract(File.GetLastAccessTime(file));
                if(ts.Days > 2)
                {
                    File.Delete(file);
                    //Console.WriteLine(string.Format("{0} {1}", file, File.GetLastAccessTime(file)));
                }
            }
        }
    }
}
