using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Services
{
    public class ClientesServices : IClientesServices
    {

        private readonly IClientesRepository _clienteRepository;
        public ClientesServices(IClientesRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public List<Clientes> getClientes()
        {
            return _clienteRepository.getClientes();
        }
        public Clientes getClientesById(int id)
        {
            return _clienteRepository.getClientesById(id);
        }

    }
}
