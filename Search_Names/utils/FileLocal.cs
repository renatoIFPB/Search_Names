using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace Search_Names.utils
{
    class FileLocal
    {
        public FileLocal() { }


        public List<Name> ReadAndSaveToClass(string path)
        {
            var list_name = new List<Name>();
            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(path)), true))
            {
                csvTable.Load(csvReader);
            }

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                var name = new Name(csvTable.Rows[i][0].ToString(), csvTable.Rows[i][1].ToString(),
                    csvTable.Rows[i][2].ToString(), csvTable.Rows[i][3].ToString());
                list_name.Add(name);
            }

            //var name1 = new Name("name1","t1","teste1","www.teste1");
            //var name2 = new Name("name2", "t2", "teste2", "www.teste2");
            //var name3 = new Name("name3", "t3", "teste3", "www.teste3");
            //list_name.Add(name1);
            //list_name.Add(name2);
            //list_name.Add(name3);
            return list_name;
        }

    }
}
