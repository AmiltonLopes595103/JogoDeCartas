using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootLuck
{
    public class Maquina
    {
        private int id;

        private String nome;

        public int getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public String getNome() {
            return nome;

        }

        public void setNome(String nome)
        {
            this.nome = nome;

        }

        public int EnergiaMaquina()
        {
            int energia = 10;

            return energia;

        }
    }
}
