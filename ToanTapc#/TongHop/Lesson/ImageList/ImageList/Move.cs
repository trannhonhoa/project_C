using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageList
{
    public enum Move
    {
        LINE_TO_TOP_AND_LINE_TO_BOTTOM,
        LEFT_TO_RIGHT_AND_RIGHT_TO_LEFT,
        TOP_TO_lINE_AND_BOTTOM_TO_LINE,
        CHANGE, 
    }
    public class Status
    {
        public Move type { get; set; }
    }
}
