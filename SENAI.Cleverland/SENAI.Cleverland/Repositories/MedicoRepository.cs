using SENAI.Cleverland.Domains;
using SENAI.Cleverland.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SENAI.Cleverland.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {

        public void CadastrarMedico(Medicos medico)
        {
            using(MedicosContext ctx = new MedicosContext())
            {
                ctx.Medicos.Add(medico);
                ctx.SaveChanges();
            }
        }

        public List<Medicos> ListarMedicos()
        {
            using (MedicosContext ctx = new MedicosContext())
            {
                return ctx.Medicos.ToList();
            }
        }
    }
}
