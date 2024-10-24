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
                a.Push(num);
                return true; //La pila tiene espacio
            }
            else
            {
                return false; //La pila está llena
            }
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
            //Imprime la lista
        }
    }// https://www.netmentor.es/entrada/tipo-stack
}
