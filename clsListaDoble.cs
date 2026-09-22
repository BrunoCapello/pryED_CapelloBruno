using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }

        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Primero == null)
            {
                Nvo.siguiente = null;
                Nvo.Anterior = null;
                Primero = Nvo;
                Ultimo = Nvo;
                return;
            }

            // Insert before first
            if (Nvo.Codigo < Primero.Codigo)
            {
                Nvo.siguiente = Primero;
                Nvo.Anterior = null;
                Primero.Anterior = Nvo;
                Primero = Nvo;
                return;
            }

            // Find insertion point
            clsNodo aux = Primero;
            while (aux != null && aux.Codigo < Nvo.Codigo)
            {
                aux = aux.siguiente;
            }

            if (aux == null)
            {
                // Insert at end
                Ultimo.siguiente = Nvo;
                Nvo.Anterior = Ultimo;
                Nvo.siguiente = null;
                Ultimo = Nvo;
            }
            else
            {
                // Insert before aux
                clsNodo prev = aux.Anterior;
                prev.siguiente = Nvo;
                Nvo.Anterior = prev;
                Nvo.siguiente = aux;
                aux.Anterior = Nvo;
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero == null)
            {
                return;
            }

            // Only one node
            if (Primero == Ultimo && Primero.Codigo == Codigo)
            {
                Primero = null;
                Ultimo = null;
                return;
            }

            // Delete first
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.siguiente;
                if (Primero != null)
                {
                    Primero.Anterior = null;
                }
                else
                {
                    Ultimo = null;
                }
                return;
            }

            clsNodo aux = Primero.siguiente;
            while (aux != null && aux.Codigo != Codigo)
            {
                aux = aux.siguiente;
            }

            if (aux == null)
            {
                // Not found
                return;
            }

            if (aux == Ultimo)
            {
                aux.Anterior.siguiente = null;
                Ultimo = aux.Anterior;
            }
            else
            {
                aux.Anterior.siguiente = aux.siguiente;
                aux.siguiente.Anterior = aux.Anterior;
            }
        }

        public void RecorrerAscendente(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerDescendente(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }

        public void RecorrerLista(ListBox lista)
        {
            clsNodo aux = Primero;
            lista.Items.Clear();
            while (aux != null)
            {
                lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.siguiente;
            }
        }

        public void RecorrerCombo(ComboBox combo)
        {
            clsNodo aux = Primero;
            combo.Items.Clear();
            while (aux != null)
            {
                combo.Items.Add(aux.Codigo);
                aux = aux.siguiente;
            }
        }
    }
}
