using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Editor_de_Grafos
{
    public class Grafo : GrafoBase, iGrafo
    {
        private bool[] visitado = new bool[999];

        public bool verificaFechados(bool[] array)
        {
            for (int u = 0; u < array.Length; u++)
            {
                if (array[u] == false)
                    return false;
            }
            return true;
        }
        public int caminhoMinimo(int i, int j)
        {
            int[] antecessor = new int[getN()];
            int[] estimativa = new int[getN()];
            bool[] fechado = new bool[getN()];
            //Atribuindo false a todos os indices! e infinto na estimativa
            for (int u = 0; u < fechado.Length; u++)
            {
                fechado[u] = false;
                estimativa[u] = 100000; // atribuindo valor imenso (simulando infinito)
            }

            // Pre preenchendo a posicao inicial
            antecessor[i] = i;
            estimativa[i] = 0;
            while (verificaFechados(fechado) == false)
            {
                int auxVet = 0;
                int maior = 100000;
                for (int u = 0; u < fechado.Length; u++) // verificando a menor estimativa
                {
                    if (estimativa[u] < maior && fechado[u] == false)
                    {
                        maior = estimativa[u];
                        auxVet = u;
                    }
                }
                //Fechando o menor
                fechado[auxVet] = true;
                for (int u = 0; u < getN(); u++) // Loop para verificar os proximos
                {
                    if (getAresta(auxVet, u) != null && fechado[u] == false)
                    {
                
                       if ((estimativa[auxVet] + getAresta(auxVet, u).getPeso()) < estimativa[u])
                       {
                            estimativa[u] = estimativa[auxVet] + getAresta(auxVet, u).getPeso();
                            antecessor[u] = auxVet;
                       }
                        
                    }
                }
            }

            int aux = j;
            while (aux != i)
            {
                getAresta(antecessor[aux], aux).setCor(Color.Red);
                aux = antecessor[aux];
            }

            return estimativa[j];
        }

        public void completarGrafo()
        {
            for (int i = 0; i < getN(); i++)
            {
                //Verifcando os vétices
                int aux = 0;
                for (int j = 0; j < getN(); j++)
                {
                    if (getAresta(i, j) != null)
                    {
                        aux++;
                    }
                }

                if (aux == 0)
                {
                    for (int j = 0; j < getN(); j++)
                    {
                        setAresta(i, j, 1);
                        getAresta(i, j).setCor(Color.Black);
                    }
                }
            }
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
                        msg += "(" + getVertice(i).getRotulo() + "," + getVertice(j).getRotulo() + "), ";
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
                        getVertice(i).setCor(Color.Chocolate);
                    }
                }
            }
        }

       
        public bool IsArvore(int v) {
            clear();
            profundidade(v);
            for (int i = 0; i < getN(); i++)
            {
                for (int j = 0; j < getN(); j++)
                {
                    if (getAresta(i, j) != null)
                    {

                       if (getAresta(i, j).getCor().ToString() != "Color [Red]")
                          return false;
                         
                    }
                }
            }
            return true;
        }

        //Minha própria implementação do AGM!
        public int AGM(int v)
        {
            int numVertices = getN(); // Guardo o número de vértices, todos serão percorridos.
            int i = 0;
            int maximo = int.MaxValue; // Guardando o valor máximo
            int verticeEscolhido = -1;
            int verticeEscolhidoOrigem = -1;
            int[] verticesVisitados = new int[getN() + 1]; // Vértices já visitados
            int pesoTotal = 0;

            verticesVisitados[0] = v; //Sempre o escolhido é o primeiro vértice visitado.
            while (i != numVertices)
            {

                for (int aux = 0; aux < verticesVisitados.Length -1; aux++) {
                    for (int j = 0; j < numVertices; j++)
                    {
                        if (getAresta(verticesVisitados[aux], j) != null) { // Caso diferente de null ela existe
                            if (getAresta(verticesVisitados[aux], j).getPeso() < maximo && !Array.Exists(verticesVisitados, element => element == j)) // caso menor que maximo e vertice ainda não visitado
                            {
                                maximo = getAresta(verticesVisitados[aux], j).getPeso();
                                verticeEscolhido = j;
                                verticeEscolhidoOrigem = verticesVisitados[aux];
                            }
                        }
                    }
                }


                if (maximo != int.MaxValue && verticeEscolhido != int.MaxValue && verticeEscolhidoOrigem != int.MaxValue) { //tendo certeza que foram atualizados
                    verticesVisitados[i + 1] = verticeEscolhido;

                    Thread.Sleep(500);
                    getVertice(verticeEscolhido).setCor(Color.Black);
                    getAresta(verticeEscolhidoOrigem, verticeEscolhido).setCor(Color.Red);

                    pesoTotal += getAresta(verticeEscolhidoOrigem, verticeEscolhido).getPeso();
                }
                maximo = int.MaxValue;
                verticeEscolhido = int.MaxValue;
                verticeEscolhidoOrigem = int.MaxValue;
                i++;
            }

            return pesoTotal;
        }

        //Minha própria implementação do número cromático!
        public int numeroCromatico(int v)
        {
            Color[] vet = new Color[8]; // Vetor guardando as cores!
            vet[0] = Color.GreenYellow;
            vet[1] = Color.Blue;
            vet[2] = Color.Red;
            vet[3] = Color.Yellow;
            vet[4] = Color.Purple;
            vet[5] = Color.Pink;
            vet[6] = Color.Gray;
            vet[7] = Color.Black;

            List<Color> CoresPassadas = new List<Color>(); // Lista de cores
            List<Color> TotalCores = new List<Color>(); // Total de cores

            Fila f = new Fila(getN());
            f.enfileirar(v);
            visitado[v] = true; // marca V como visitado
            int j = 0;
            while (!f.vazia())
            {
                v = f.desenfileirar(); // retira o próximo vértice da fila
                if (j == 0)
                {// Colorindo o primeiro vértice.
                    getVertice(v).setCor(vet[0]);
                    TotalCores.Add(vet[0]);
                }
                for (int i = 0; i < getN(); i++)
                {
                    // se I é adjacente a V e I ainda não foi visitado
                    if (getAresta(v, i) != null && !visitado[i])
                    {
                        visitado[i] = true; // marca i como visitado
                        getAresta(v, i).setCor(Color.Red); // Marcando a linha visitada
                        //Validação de vizinhos para cor!
                        for (int u = 0; u < getN(); u++)
                        {
                            if (getAresta(i, u) != null && getVertice(u).getCor() != Color.Chocolate) // cor chocolate, não foi visitado ainda.
                            {
                                CoresPassadas.Add(getVertice(u).getCor());
                            }
                        }

                        int marcador = 0;
                        for (int color = 0; color < vet.Length; color++)
                        {
                                                        
                            if(!CoresPassadas.Contains(vet[color]) && marcador == 0)
                            {
                               getVertice(i).setCor(vet[color]);
                               if (!TotalCores.Contains(vet[color])) // Alimentando lista adicional para calculado o xgh
                               {
                                  TotalCores.Add(vet[color]);
                               }
                               marcador++;
                            }
                                                      
                        }
                        CoresPassadas.Clear(); // Limpando lista

                        Thread.Sleep(1000);
                        f.enfileirar(i); // enfileira i
                    }
                }
                j++;
            }

            return TotalCores.Count;
        }

    }
}
