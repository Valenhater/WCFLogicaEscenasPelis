using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFLogicaEscenasPelis.Models;

namespace WCFLogicaEscenasPelis
{
    [ServiceContract]
    public interface IEscenasContract
    {
        [OperationContract]
        List<Escena> GetEscenas();
        [OperationContract]
        Escena FindEscena(int idescena);
    }
}
