using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGit
{
    class HotelP
    {
        public int HotelNo { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public HotelP(int hotelNo, string name, string adress)
        {
            HotelNo = hotelNo;
            Name = name;
            Adress = adress;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
