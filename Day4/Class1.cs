using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patientModule
{
    class Class1
    {
    }

    class IndexedClass
    {
        private String[] names = new string[10];

        public string this[int index]
        {
            get
            {
                return (index >= 0 && index <= 9) ? names[index] : "";
            }
            set
            {
                if(index >= 0 && index <= 9){
                    names[index] = value;
                }
            }
        }
    }
}
