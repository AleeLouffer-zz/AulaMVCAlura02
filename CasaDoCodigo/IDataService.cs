using System;
using System.Threading.Tasks;

namespace CasaDoCodigo
{
    interface IDataService
    {
        Task InicializaDBAsync(IServiceProvider provider);
    }
}