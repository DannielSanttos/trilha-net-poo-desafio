using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", imei: "111111111", modelo: "Modelo 1", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "789012", imei: "222222222", modelo: "Modelo 2", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
