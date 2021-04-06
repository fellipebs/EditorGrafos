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
        void AGM(int v);
        void caminhoMinimo(int i, int j);
        void numeroCromatico();
    }
}
