using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS_ListaAd
{
    internal class GrafoBFS 
    {
        private int v;
        private ListEnlDoble[] adj;

        public GrafoBFS(int v)
        {
            this.v = v;
            adj = new ListEnlDoble[v];
            for (int i = 0; i < adj.Length; i++)
            {
                adj[i] = new ListEnlDoble();
            }
        }

        public void AgregarArista(int v, int w)
        {
            adj[v].AgregaFin(w);
        }


        public void BFS(int inicio)
        {
            bool[] visitado = new bool[v];

            Cola cola = new Cola();

            visitado[inicio] = true;
            cola.Encolar(inicio);

            Console.WriteLine("--------------------------");
            Console.WriteLine("      RECORRIDO BFS");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Vértice inicial: {inicio}");
            Console.WriteLine();

            Console.Write("Visitando: ");

            bool primero = true;

            while (!cola.EstaVacia())
            {
                int actual = cola.Desencolar();

                if (!primero)
                {
                    Console.Write(" -> ");
                }

                Console.Write($"[{actual}]");
                primero = false;

                ListEnlDoble vecinos = adj[actual];

                for (int i = 0; i < vecinos.Length(); i++)
                {
                    int vecino = vecinos.Get(i);

                    if (!visitado[vecino])
                    {
                        visitado[vecino] = true;
                        cola.Encolar(vecino);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("--------------------------");
        }
    }
}
