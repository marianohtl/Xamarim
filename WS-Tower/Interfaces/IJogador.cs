﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WS_Tower.Controllers;
using WS_Tower.Domains;

namespace WS_Tower.Interfaces
{
    interface IJogador
    {
        //Lista de Seleções
        List<Jogador> GetAllPlayers();

        List<Jogador> GetByName(string name);
    }
}
