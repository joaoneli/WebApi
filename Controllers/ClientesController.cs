﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IClientesServices _clienteServices;
        public ClientesController(IClientesServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet]

        public ActionResult<List<Clientes>> getClientes()
        {

            var clientes = _clienteServices.getClientes();
            if (clientes == null)
            {
                return NotFound("Nenhum cliente encontrado");
            }
            return Ok(clientes);
        }

        [HttpGet("{id}")]

        public ActionResult<Clientes> getClientesById(int id)
        {
            var clientes = _clienteServices.getClientesById(id);

            if (clientes == null)
            {
                return NotFound("Nenhum cliente encontrado");
            }
            return Ok(clientes);
        }

    }
}
