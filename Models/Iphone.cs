using System;
using System.Reflection;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {}

        public override void InstalarAplicativo(string appName)
        {
            Console.WriteLine($"Instalando aplicativo {appName} no Iphone.");
        }
    }
}