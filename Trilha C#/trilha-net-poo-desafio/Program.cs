using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia: ");
var nokia = new Nokia(numero: "1234", modelo: "AX2055", iMEI: "111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "whatsapp");

Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
var iphone = new Iphone(numero: "145688", modelo: "iphone6", iMEI: "22222", memoria: 84);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "instagram");