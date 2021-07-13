using senai_czbooks_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_czbooks_webApi.Interfaces
{
    interface IAutoresRepository
    {
        List<Autore> Listar();

    }
}
