using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
   public  class clsPila2
   {
        //atributos
        public const int Max = 100;
        int[] pila;
        int tope1;
        int tope2;
        int cant;

        //Constructor
        public clsPila2()
        {
            int cant = 0;
            tope1 = -1;
            tope2 = Max;
            pila = new int[Max];
            for (int i = 0; i < Max; i++){
                pila[i] = 0;
            }

        }

        public clsPila2( clsPila2 p)
        {
            int cant = p.cant;
            tope1 = p.tope1;
            tope2 = p.tope2;
            pila = new int[Max];
            for (int i = 0; i < Max; i++)
            {
                pila[i] = 0;
            }

        }

        //Add(S,x) -->S  // Adiciona el elemento x la pila,
        public void Add(int S, int x)
        {
            if (S == 0)
            {
                if (!Llena(S))
                {
                    tope1++;
                    pila[tope1] = x;
                    cant++;
                }
            }
            else
            {
                if (!Llena(S))
                {
                    tope2--;
                    pila[tope2] = x;
                    cant++;
                }
            }

        }

        // Delete(S) -->S  // Elimina el elemento tope de la pila
        public void Delete(int S)
        {
            if (S == 0)
            {
                if (!Vacia(S))
                {
                    tope1--;
                    cant--;
                }
            }
            else
            {
                if (!Vacia(S))
                {
                    tope2++;
                    cant--;
                }
            }
        }

        // Vacia(S) --> Boolean       // Retorna TRUE si S esta vacía de lo contrario FALSE
        public bool Vacia(int S)
        {
            bool b = false;
            if (S == 0)
            {
                if (tope1 == -1)
                {
                    b = true;
                }
            }
            else
            {
                if (tope2 == Max)
                {
                    b = true;
                }
            }
            return b;
        }

        //Llena(S) -->  Boolean        // Retorna TRUE si S esta llena de lo contrario FALSE
        public bool Llena(int S)
        {
            bool b = false;
            if (S == 0)
            {
                if (tope1 + 1 == Max / 2)
                {
                    b = true;
                }
            }
            else
            {
                if (tope2 - 1 == Max / 2)
                {
                    b = true;
                }
            }
            return b;
        }


        public String Imprimir()
        {
            String S = "";
            for (int i = 0; i <= tope1; i++){
                S = S + "[" + pila[i] + "]";
            }
            for (int i = tope2; i < Max; i++)
            {
                S = S + "[" + pila[i] + "]";
            }
            return S;
        }








    }
}
