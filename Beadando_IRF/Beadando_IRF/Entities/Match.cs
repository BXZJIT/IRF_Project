﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando_IRF.Entities
{

    public class Match
    {
        public string categoryName { get; set; }
        public string id { get; set; }
        public string localTeam { get; set; }
        public string visitorTeam { get; set; }
        public string localAndVisitor { get; set; }
        public string time { get; set; }
    }
    
}
