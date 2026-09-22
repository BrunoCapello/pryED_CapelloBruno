using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    internal class clsListaSimple
    {
        private clsNodo primero;

        public clsNodo Primero { get => primero; set => primero = value; }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo <= Primero.Codigo)
                {
                    Nuevo.siguiente = Primero;
                    Primero = Nuevo;
                }
                else
                {
                    clsNodo aux = Primero;
                    clsNodo ant = Primero;
                    while (aux != null && Nuevo.Codigo > aux.Codigo)
                    {
                        ant = aux;
                        aux = aux.siguiente;
                    }

                    ant.siguiente = Nuevo;
                    Nuevo.siguiente = aux;
                }
            }
        }

        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo == Codigo)
            {
                Primero = Primero.siguiente;
            }
            else
            {
                clsNodo ant = Primero;
                clsNodo aux = Primero;
                while (aux.Codigo != Codigo)
                {
                    ant = aux;
                    aux = aux.siguiente;
                }
                ant.siguiente = aux.siguiente;
            }
        }

        

        public void RecorrerDGV(DataGridView dgv)
        {
            clsNodo aux = Primero;
            dgv.Rows.Clear();
            while (aux != null)
            {
                dgv.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.siguiente;
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
