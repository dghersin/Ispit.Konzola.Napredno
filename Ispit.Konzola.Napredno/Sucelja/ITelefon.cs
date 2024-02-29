using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Napredno.Sucelja
{
    public interface ITelefon
    {
        string Model { get; }
        string Poziv(string telefonski_broj);
    }
}
