﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Repositories;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : Controller
    {
        private readonly IClienteServices _clienteServices;
        public ClientesController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        [HttpGet]

        public IEnumerable<Clientes> GetClientes()
        {
            return _clienteServices.getClientes();
        }

        [HttpGet("{id}")]

        public ActionResult<Clientes> GetClienteById(int id)
        {
            var clientes = _clienteServices.getClientesById(id);

            if (clientes == null)
            {
                return NotFound("Nenhum cliente encontrado");
            }
            return clientes;
        }

    }
}