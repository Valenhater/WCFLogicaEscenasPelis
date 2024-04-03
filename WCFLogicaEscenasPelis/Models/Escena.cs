﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFLogicaEscenasPelis.Models
{
    [DataContract]
    public class Escena
    {
        [DataMember]
        public int IdEscena { get; set; }
        [DataMember]
        public string TituloEscena { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Imagen { get; set; }
    }
}
