using SENAI.Cleverland.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Cleverland.Interfaces
{
    interface IMedicoRepository
    {
        void CadastrarMedico(Medicos medico);
        List<Medicos> ListarMedicos();
 
    }
}
