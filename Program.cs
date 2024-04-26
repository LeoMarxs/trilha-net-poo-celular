using DesafioPOO.Models;

System.Console.WriteLine("\nSmartphone Nokia:");

Smartphone nokia = new Nokia(numero: "123456", Modelo: "Tijolão", IMEI: "1111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("-------------------------------------");

System.Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone(numero: "479722", Modelo: "15", IMEI: "2222222", Memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");