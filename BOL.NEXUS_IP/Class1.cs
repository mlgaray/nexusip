using DAL.NEXUS_IP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.NEXUS_IP
{
    public class Class1
    {

        dalClass miClase = new dalClass();

        public void getById(int id)
        {

            miClase.getById(id);
        }


    }
}
