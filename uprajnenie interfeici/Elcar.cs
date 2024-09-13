using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie_interfeici
{
    public interface Elcar
    {
        string Model { get; set; }
        string Color { get; set; }
        int Baterry {  get; set; }
        string Start();
        string Stop();
    }
}
