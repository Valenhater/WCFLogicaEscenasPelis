using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFLogicaEscenasPelis.Models;
using WCFLogicaEscenasPelis.Repositories;

namespace WCFLogicaEscenasPelis
{
    public class EscenasClass : IEscenasContract
    {
        private RepositoryEscenas repo;

        public EscenasClass()
        {
            this.repo = new RepositoryEscenas();
        }
        public Escena FindEscena(int idescena)
        {
            return this.repo.FindEscena(idescena);
        }

        public List<Escena> GetEscenas()
        {
            return this.repo.GetEscenas();
        }
    }
}
