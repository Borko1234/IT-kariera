using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5._3
{
    public interface Imachine
    {
        string Type { get; set; }
        string Start();
        string Stop();
    }
}
