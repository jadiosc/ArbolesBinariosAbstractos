using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arboles
{
    public abstract class abstract_NodoBinario
    {
        #region Propiedades

        protected object _dato;
        /// <summary>
        /// Objeto que guarda el dato
        /// </summary>
        public object Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        /// <summary>
        /// Nodo de la Rama Izquierda del árbol
        /// </summary>
        public abstract NodoBinario ramaIzquierda { get; set; }

        /// <summary>
        /// Nodo de la Rama Derecha del árbol
        /// </summary>
        public abstract NodoBinario ramaDerecha { get; set; }
        #endregion Propiedades   
        #region Constructores
        public abstract_NodoBinario(Object valor)
        {
            Dato = valor;
            ramaDerecha = ramaIzquierda = null;
        }
        public abstract_NodoBinario(NodoBinario ramaIzq, Object valor, NodoBinario ramaDer):this(valor)
        {
            ramaIzquierda = ramaIzq;
            ramaDerecha = ramaDer;
        }
        #endregion
    }
}