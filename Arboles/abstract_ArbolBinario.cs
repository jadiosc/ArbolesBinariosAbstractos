using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    abstract public class abstract_ArbolBinario
    {
        #region Propiedades
        abstract public NodoBinario Raiz { get; set; }
        abstract public bool esVacio { get; }
        abstract public int nivel { get; }
        abstract public int altura { get; }
        abstract public int numNodos { get; }
        #endregion
        #region Constructores
        public abstract_ArbolBinario(NodoBinario raiz)
        {
            Raiz = raiz;
        }
        public abstract_ArbolBinario()
        {
            Raiz = null;
        }
        #endregion
        #region Métodos
        public abstract bool vacio();
        public abstract string preorden();
        public abstract string inorden();
        public abstract string postorden();
        #endregion
    }
}
