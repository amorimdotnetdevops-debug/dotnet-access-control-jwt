using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prontuario.Infra.Auth
{
    public interface IJwtProvider
    {
        string Generate(string loginUsuario);
    }
}
