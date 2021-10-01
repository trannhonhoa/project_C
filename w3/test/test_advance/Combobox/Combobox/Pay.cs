using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combobox
{
    public class Pay{

        public int Ma { get; set; }
        public string hinhthuc { get; set; }
        public int PhiThanhToan {get; set;}

        public override string ToString()
        {
            return this.hinhthuc;
        }
    }
}
