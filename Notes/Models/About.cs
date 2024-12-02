using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => "ANGEL ARMANDO VELA TITUAÑA";
        public string MoreInfoUrl { get; set; }
        public string Message => "MAS VALE TARDE QUE NUNCA";
    }
}
