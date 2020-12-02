using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly DataContext _context;
        public ClientesRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Clientes> getClientes()
         {
             return _context.Cliente.ToList();
         }
         public Clientes getClientesById(int id)
         {
             return _context.Cliente.Find(id);
         }
    }
}
