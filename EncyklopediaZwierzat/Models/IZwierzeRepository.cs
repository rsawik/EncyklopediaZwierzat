﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.Models
{
    public interface IZwierzeRepository //2
    {
        IEnumerable<Zwierze> PobierzWszystkieZwierzeta();
        Zwierze PobierzZwierzeOId(int zwierzeID);
        void DodajZwierze(Zwierze zwierze);
        void EdytujZwierze(Zwierze zwierze);
        void UsunZwierze(Zwierze zwierze);
    }
}
