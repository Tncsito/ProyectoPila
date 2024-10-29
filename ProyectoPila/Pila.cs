using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPila
{
    internal class Pila
    {
        private int MAX;
        private int tope = 0;
        private NODO inicio;
        Stack<int> a = new Stack<int>();
        public Pila(int MAX)
        {
            this.MAX = MAX;
            inicio = null;
        }
        public void Tope(int n)
        {
            tope = n;
        }
        public bool Empty()
        {
            if(inicio == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Full()
        {
            if(tope == MAX)
            {
                return true;
            } else
            { 
                return false; 
            }
        }
        public bool Push(int num)
        {
            if ( !Full() )
            {
                NODO nuevo = new NODO(num);
                inicio = nuevo;
                inicio = inicio.Sig;
                    //La pila tiene espacio
            }
            return false;//La pila está llena
        }
        public int Pop()
        {
            if ( !Empty() )
            {
                return tope;
            }
            return tope;
            //Regresa el numero sacado de la pila y si está vacía regresa -1
        }
        public void PrintStack()
        {
            NODO act;
            act = inicio;
            while (act != null)
            {
                Console.Write($"{act.Valor} => ");
                if (act.Sig != null)
                {
                    act = act.Sig;
                }
                else
                {
                    act = act.Sig;
                    Console.Write("NULL");
                }
                //Imprime la lista
            }
        }
    }// https://www.netmentor.es/entrada/tipo-stack
}
