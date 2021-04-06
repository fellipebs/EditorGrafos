using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;

namespace Editor_de_Grafos
{
    public class Grafo : GrafoBase, iGrafo
    {
        private bool[] visitado = new bool[999];

        public void AGM(int v)
        {

        }

        public void caminhoMinimo(int i, int j)
        {

        }

        public void completarGrafo()
        {

        }

        public bool isEuleriano()
        {
            int i;
            for (i = 0; i < getN(); i++)
            {
                if (grau(i) % 2 != 0)
                    return false;

            }
            if (getN() != 0)
                return true;
            else
                return false;
        }

        public bool isUnicursal()
        {
            int grauImpar = 0;
            for (int i = 0; i < getN(); i++)
            {
                if (grau(i) % 2 != 0)
                    grauImpar++;
            }
            return (grauImpar == 2);
        }

        public void largura(int v)
        {
            // vetor VISITADO[] deve ser inicializado com FALSE
            Fila f = new Fila(getN());
            f.enfileirar(v);
            visitado[v] = true; // marca V como visitado
            while (!f.vazia())
            {
                v = f.desenfileirar(); // retira o próximo vértice da fila
                for (int i = 0; i < getN(); i++)
                {
                 // se I é adjacente a V e I ainda não foi visitado
                   if (getAresta(v, i) != null && !visitado[i])
                   {
                       visitado[i] = true; // marca i como visitado
                       getAresta(v, i).setCor(Color.Red);
                       getVertice(i).setCor(Color.Black);
                       Thread.Sleep(1000);
                       f.enfileirar(i); // enfileira i
                    }
                }
            }
        }

        public void numeroCromatico()
        {
        }

        public String paresOrdenados()
        {
            //matAdj.GetLength(0)
            if (getN() == 0)
                return "Matriz vazia.";
            string msg = "E={";
            for (int i = 0; i < getN(); i++)
            {
                for (int j = 0; j < getN(); j++)
                {
                    if (getAresta(i,j) != null)
                        msg += "(" + i + "," + j + "), ";
                }
            }
            msg = msg.Substring(0, msg.Length - 2) + "}";
            return msg;
        }
        public void profundidade(int v)
        {
            // vetor VISITADO[] deve ser inicializado com FALSE
            // bool[] visitado;
                visitado[v] = true; // marca V como visitado
                for (int i = 0; i < getN(); i++)
                {
                    // se I é adjacente a V e I ainda não foi visitado
                    if (getAresta(v, i) != null && !visitado[i])
                    {
                    // chamada recursiva (vá para o vértice I)
                     getAresta(v, i).setCor(Color.Red);
                     getVertice(i).setCor(Color.Black);
                     Thread.Sleep(1000);
                     profundidade(i);
                    }
                }
            
        }

        public void setaFalse() {
            for (int j = 0; j < getN(); j++)
            {
                visitado[j] = false;
            }
        }

        public void clear() {
            setaFalse();
            for (int i = 0; i < getN(); i++)
            {
                for (int j = 0; j < getN(); j++)
                {
                    if (getAresta(i, j) != null)
                    {
                        getAresta(i, j).setCor(Color.Black);
                        getVertice(i).setCor(Color.Orange);
                    }
                }
            }
        }

       
        public bool IsArvore(int v) {
            clear();
            profundidade(v);
            for (int i = 0; i < getN() - 1; i++)
            {
                for (int j = 0; j < getN() - 1; j++)
                {
                    if (getAresta(i, j).getCor().ToString() != "Color [Red]")
                        return false;
                        
                }
            }
            return true;
        }
        
    }
}
