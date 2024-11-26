using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Apple : Smartphone
    {
        public Apple(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nome}\" no {Modelo}");
        }
    }
}