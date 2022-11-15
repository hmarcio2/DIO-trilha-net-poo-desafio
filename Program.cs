using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "modelo 1", IMEI: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "456789", modelo: "modelo 2", IMEI: "22222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
Console.WriteLine("\n");


/*  // Testando acessibilidade de dados protegidos
nokia.IMEI = "12345678";
iphone.Memoria = 256;
nokia.modelo = "ultimo modelo";
*/