using System;
using System.Collections.Generic;
using System.Text;

namespace SCM.AplicationCore.Entity
{
    public class Multa
    {

        public int Id { get; set; }

        public decimal Valor { get; set; }

        public double Pontuacao { get; set; }


        //Propriedade de navegação //

        public Veiculo Veiculo { get; set; }

    }
}
