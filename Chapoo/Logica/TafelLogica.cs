﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAdaptor;

namespace Logica
{
    public class TafelLogica
    {
        public TafelDAO TafelDao = new TafelDAO();
        public Tafel TafelVuller(int tafelnummer)
        {
            Tafel tafel = TafelDao.TafelInfoVuller(tafelnummer);
            return tafel;
        }
    }
}