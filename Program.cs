using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia("1234", "Modelo 1", "111111111111111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone("4321", "Modelo 2", "22222222222222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
