using EncyklopediaZwierzat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.ViewModels
{
    public class HomeVM
    {
        public string Tytul { get; set; }
        public List<Zwierze> Zwierzeta { get; set; }
    }
}
