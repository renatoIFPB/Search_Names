using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Names.utils
{
    class GetOriginNames
    {
        public List<string> origins { get; set; }

        public GetOriginNames() { }

        public void ConvertObjNameToFileTxt(List<Name> male, List<Name> female, string path)
        {
            //if (File.Exists(path)) //exception!!!, arquivo já existe
            //    return;

            foreach (var i in male)
            {
                var tmp_split = i.origin.Trim().Split(",");
                foreach (var o in tmp_split)
                {
                    var tmp_o = o.Trim();
                    if (!origins.Contains(tmp_o))
                        origins.Add(tmp_o);
                }
            }
            foreach (var i in female)
            {
                var tmp_split = i.origin.Split(",");
                foreach (var o in tmp_split)
                {
                    var tmp_o = o.Trim();
                    if (!origins.Contains(tmp_o))
                        origins.Add(tmp_o);
                }
            }
            SaveOriginsToTxt(path);
        }

        public void SaveOriginsToTxt(string path)
        {
            using (StreamWriter writetext = new StreamWriter(path))
            {
                foreach (var line in origins)
                {
                    writetext.WriteLine(line);
                }
            }
        }
    }
}
