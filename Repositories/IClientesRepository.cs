﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repositories
{
    public interface IClientesRepository
    {
        List<Clientes> getClientes();
        Clientes getClientesById(int id);
    }
}
    