﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uprajnenie_interfeici
{
    public interface icar
    {
        string Model{ get;set; }
        string Color{ get; set; }
        string Start();
        string Stop();
    }
}
