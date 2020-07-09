using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.Model
{
    class ProgressIndicate
    {
        public int current;
        public int count;
        public string name;

        public ProgressIndicate()
        {
            current = 1;
            count = 1;
            name = "";
        }
    }

}

