using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gh_test_internal
{
    class person
    {
        public string Name;
        public int Namelen;
        public int Pnum;
        public ugliness pugli;

        public person(int i,string n)
        {
            Name = n;
            Pnum = i;
            int m = n.Length;
            Namelen = m;
            pugli = new ugliness(this);
        }


        public string GetDetail()
        {
            string st = "hi " + Name + " your are person number " + Pnum.ToString() + " your name is " + Namelen.ToString() + " chars long, you are " + (pugli.uglyfactor * 100).ToString() + " % ugly";
            return st;
        }

    }
}
