﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = "tartaruga dentro do casco, ";
            this.acao = "rodando no chao - ";

        }

        public override void Mostra(string qualCor)
        {
            this.cor = qualCor;
            Console.WriteLine(condicao + acao + cor.ToUpper());
        }
    }
}
