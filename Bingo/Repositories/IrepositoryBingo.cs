using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bingo.Repositories
{
     public interface IrepositoryBingo
    {
        List<int> GenerarNumeros();

        List<int> NumerosAleatorios();

        List<int> GenerarCartones();

        int[,] validarCarton(List<int> Ordenados);

        int[,] taparCartones(int[,] carton);
    }
}
