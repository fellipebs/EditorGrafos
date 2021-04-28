using System;
using System.Collections.Generic;
using System.Text;

namespace Editor_de_Grafos
{
    interface iGrafo
    {
        bool isEuleriano();
        bool isUnicursal();
        string paresOrdenados();
        void completarGrafo();
        void profundidade(int v);
        void largura(int v);
        int AGM(int v);
        int caminhoMinimo(int i, int j);
        int numeroCromatico(int v);
    }
}
