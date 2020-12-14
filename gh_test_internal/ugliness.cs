using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gh_test_internal
{
    class ugliness
    {
        int zits;
        bool uglyteeth;
        double weight;
        double uglyfactor;

        public ugliness(person p)
        {
            string name = p.Name;
            int q = name.Length;
            zits = q;
            weight = q * 20;
            double xx = zits * weight;
            uglyteeth = false;
            uglyfactor = (double)1/xx;
            if (uglyfactor >0.5) { uglyteeth = true; } 
        }
        
    }
}
