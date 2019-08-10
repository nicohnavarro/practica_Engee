using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opcionales_01
{
    public class RelojException:Exception
    {
        public RelojException(string mensaje) : base(mensaje) { }
    }
}
