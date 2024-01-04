using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "a57", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

