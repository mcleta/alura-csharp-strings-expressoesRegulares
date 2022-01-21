using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClassTeste
    {
        public ClassTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da classe "ModificadoresTeste"
        }
        private void MetodoPrivado()
        {
            //Visível apenas na classe "ModificadoresTeste"
        }
    }
}
