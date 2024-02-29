using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Napredno.Sucelja
{
    interface IPametniTelefon : ITelefon
    {
        string Surfanje(string url);
    }
}
