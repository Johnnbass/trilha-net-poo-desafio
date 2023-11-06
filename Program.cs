using System;
using DesafioPOO.Models;

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone("998877665", "Modelo I", "684930211009345", 128);
iphone.Ligar();
iphone.ListarDadosSmartphone();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("\n---------------------------------------------------------------------\n");

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("991188227", "Modelo N", "789993750001199", 64);
nokia.Ligar();
nokia.ListarDadosSmartphone();
nokia.InstalarAplicativo("Facebook");