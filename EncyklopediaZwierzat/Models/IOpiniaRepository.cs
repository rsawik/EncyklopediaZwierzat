using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.Models
{
    public interface IOpiniaRepository
    {
        void DodajOpinie(Opinia opinia);
    }
}
