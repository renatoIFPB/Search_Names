using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Names.utils
{
    class GetOriginNames
    {
        List<string> origins;
        public GetOriginNames() { }

        public void Convert_ObjName_to_ListOrigins(List<Name> names)
        {
            foreach (var i in names)
            {
                var tmp_split = i.origin.Trim().Split(",");
                foreach (var o in tmp_split)
                {
                    origins.Add(o);
                }
            }
        }

        private void Save_Origins_to_File()
        {

        }
    }
}
