using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootLuck
{
    public class Player
    {
        private int id;
        private String nome;
        private Gols gol;
        private Energias energia;
        private Penalidades penalidade;
        public int getID()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }


        public String getNome()
        {
            return nome;

        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        
        public String toString(){
            return nome;
        }


      


        




    }
}
