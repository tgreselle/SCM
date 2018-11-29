using System;
using System.Collections.Generic;
using System.Text;

namespace SCM.AplicationCore.Entity
{
    public class Veiculo
    {
        public int Id { get; set; }

        public string Placa { get; set; }

        public int Renavam { get; set; }


        //Propriedade de navegação //

        public List<Multa> Multas { get; set; }

    }
}
