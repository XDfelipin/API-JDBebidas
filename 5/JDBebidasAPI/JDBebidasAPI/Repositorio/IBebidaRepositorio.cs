﻿using JDBebidasAPI.Model;
using JDBEBIDASAPI.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JDBEBIDASAPI.Repositorio
{
    public interface IBebidaRepositorio
    {
        Task<IEnumerable<Bebida>> Get();

        Task<Bebida> Get(int Id);

        Task<Bebida> Create(Bebida bebida);

        Task Update(Bebida bebida);

        Task Delete(int Id);
    }
}
