using Ispit.Konzola.Napredno.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Napredno
{
    public class PametniTelefon : IPametniTelefon
    {
        public string Model { get; private set; }

        public PametniTelefon(string model)
        {
            Model = model;
        }

        public string Surfanje(string url)
        {
            if (ProvjeriAkoJeValidanUrl(url))
            {
                return $"Moguće je surfati na {url}.";
            }
            else
            {
                return "Neispravan url!";
            }
        }

        public string Poziv(string telefonski_broj)
        {
            if (ProvjeriAkoJeValidanBroj(telefonski_broj))
            {
                return $"Moguće je zvati broj {telefonski_broj}.";
            }
            else
            {
                return "Neispravan telefonski broj!";
            }
        }

        public bool ProvjeriAkoJeValidanUrl(string url)
        {
            foreach (char c in url)
            {
                if (char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ProvjeriAkoJeValidanBroj(string telefonski_broj)
        {
            foreach (char c in telefonski_broj)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
