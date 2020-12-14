using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gh_test_internal
{
    class personList
    {
        public List<person> Lp;
        
        public personList(List<string> ls)
        {
            List<person> Plist = new List<person>();
            for (int i = 0;i<ls.Count;i++)
            {
                person p1 = new person(i, ls[i]);
                Plist.Add(p1);
                
            }
            Lp = Plist;
        }

        public List<string> GetAllPeople()
        {
            List<string> nl = new List<string>();
            foreach (person pr in Lp)
            {
                string stl = pr.GetDetail();
                nl.Add(stl);
            }
            return nl;
        }
    }
}
