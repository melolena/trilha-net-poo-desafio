using DesafioPOO.Models;

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "2345-5567", modelo: "Flip", imei: "00000", memoria: 180);
nokia.Ligar();
nokia.InstalarAplicativo("Twitter");


Console.WriteLine("\n");


Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero:"1234-0077", modelo: "Iphone 14", imei: "00001", memoria: 94);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("TikTok");

Console.WriteLine("\n");