using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Names
{
    public class Name
    {

        public string name { get; set; }
        public string meaning { get; set; }
        public string origin { get; set; }
        public string link { get; set; }

        public Name() { }
        public Name(string Name, string Meanig, string Origin, string Link)
        {
            name = Name;
            meaning = Meanig;
            origin = Origin;
            link = Link;
        }

        //public class Unit
        //{
        //    public string name { get; set; }
        //    public string meaning { get; set; }
        //    public string origin { get; set; }
        //    public string link { get; set; }

        //    public Unit() { }
        //    public Unit(string Name, string Meanig, string Origin, string Link)
        //    {
        //        name = Name;
        //        meaning = Meanig;
        //        origin = Origin;
        //        link = Link;
        //    }
        //}

        //public class List
        //{
        //    public List<Unit> listUnit { get; set; }

        //    public void add(Unit name) => listUnit.Add(name);
        //}
    }
}
