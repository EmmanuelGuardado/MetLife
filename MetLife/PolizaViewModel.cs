using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetLife
{
    class PolizaViewModel
    {
        public int Id { get; set; }
        public string CodigoPoliza { get; set; }

        public PolizaViewModel()
        {
            this.Id = 1;
        }

    }
}
