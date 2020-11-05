using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaCircularEstatica
{
    class ColaCircular
    {
        private int final;
        public int tail
        {
            get { return final; }
            set { final = value; }
        }
        private int frente;
        public int head
        {
            get { return frente; }
            set { frente = value; }
        }
        private int maximo;
        public int Maximo
        {
            get { return maximo; }
            set { maximo = value; }
        }
        public string[] arregloCircular;
        public ColaCircular(int Tamaño)
        {
            Maximo = Tamaño;
            arregloCircular = new string[Maximo];
            tail = head = -1;
        }
        public bool EstaLlena()
        {
            if (tail == Maximo - 1 && head == 0 || tail + 1 == head)
            {
                return true;
            }
            return false;
        }
        public bool EstaVacia()
        {
            if (head == -1)
            {
                return true;
            }
                return false;
        }
        public string Front()
        {
            return arregloCircular[head];
        }
        public void Encolar(string elemento)
        {
            if (EstaVacia())
            {
                head = tail = 0;
                arregloCircular[head] = elemento;
                return;
            }
            if (EstaLlena())
            {
                return;
            }
            if (tail == Maximo - 1)
            {
                tail = 0;
                arregloCircular[tail] = elemento;
                return;
            }
            else
            {
                tail++;
                arregloCircular[tail] = elemento;
            }
        }
        public void Desencolar()
        {
            if (EstaVacia())
            {
                return;
            }
            else
            {
                if (head == tail)
                {
                    arregloCircular[head] = null;
                    tail = head = -1;
                }
                else
                {
                    if (head == Maximo - 1)
                    {
                        arregloCircular[head] = null;
                        head = 0;
                    }
                    else
                    {
                        arregloCircular[head] = null;
                        head++;
                    }
                }
            }
        }
        public string Imprimir()
        {
            string colaString = "";
            if (EstaVacia())
            {
                return "La cola esta vacia";
            }
            else
            {
                colaString += arregloCircular[0];
                for (int i = 1; i < arregloCircular.Length; i++)
                {

                    colaString += "," + arregloCircular[i];
                }
                return colaString;
            }
        }
        public string guardarFormato()
        {
            string colaString = "";
            if (EstaVacia())
            {
                return "La cola esta vacia";
            }
            else
            {
                colaString+= arregloCircular[head];
                for (int i = head + 1; i != tail + 1; i++)
                {
                    colaString += "," + arregloCircular[i];
                    if (i == arregloCircular.Length - 1)
                    {
                        i = -1;
                    }
                }
                return colaString;
            }
        }
    }
}
