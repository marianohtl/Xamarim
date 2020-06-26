﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WS_Tower.Interfaces;
using WS_Tower.Interfaces;
using WS_Tower.Repositories;

namespace WS_Tower.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class SelecaoController : ControllerBase
    {

        private ISelecao _selecao;

        public SelecaoController()
        {
            _selecao = new SelecaoRepository();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAllTeams()
        {
            return Ok(_selecao.GetAllTeams());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetGamersTeamsById(int id)
        {
            return Ok(_selecao.GetGamersTeamsById(id));
        }


        [HttpGet("Teams")]
        public IActionResult GetTeams()
        {
            return Ok(_selecao.GetTeams());
        }

        [HttpGet("GetByPlayers/{id}")]
        public IActionResult GetPlayers(int id)
        {
            return Ok(_selecao.GetPlayers(id));
        }
    }
}