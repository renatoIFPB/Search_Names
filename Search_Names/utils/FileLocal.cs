using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;
using System.ComponentModel;
using System.Globalization;
using LINQtoCSV;

namespace Search_Names.utils
{
    class FileLocal
    {
        public FileLocal() { }

        public List<Name> InicializateObjNames(string path)
        {
            if (!File.Exists(path)) //exception
                return null;

            var list_name = new List<Name>();
            var csvTable = new DataTable();

            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(path)), true))
                csvTable.Load(csvReader);

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                var name = new Name(csvTable.Rows[i][0].ToString(), csvTable.Rows[i][1].ToString(),
                    csvTable.Rows[i][2].ToString(), csvTable.Rows[i][3].ToString());
                list_name.Add(name);
            }
            return list_name;
        }

        public List<string> CreateListByFileTxt(string path)
        {
            if (!File.Exists(path)) //exception
                return null;

            var list = new List<string>();
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var readerFile = new StreamReader(file, Encoding.UTF8))
            {
                string line;
                while ((line = readerFile.ReadLine()) != null)
                    list.Add(line);
            }
            return list.OrderBy(q => q).ToList();
        }


        public List<Name> ReadCsv(string path)
        {
            var list = new List<Name>();

            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ';',
                UseFieldIndexForReadingData = false
            };

            var csvContext = new CsvContext();
            var tmp = csvContext.Read<Name>(path, csvFileDescription);

            foreach (var name in tmp)
                list.Add(name);

            return list;
        }


        public void WriteCsv(string path, List<Name> name)
        {
            var list = new List<Name>();
            if (File.Exists(path)) //exception
            {
                list = ReadCsv(path);
            }

            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                SeparatorChar = ';'
            };

            var csvContext = new CsvContext();
            csvContext.Write(name, path, csvFileDescription);
        }

    }
}
