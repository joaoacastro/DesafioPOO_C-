using DesafioPOO.Models;

Console.WriteLine("\nSmartphone Samsung:");
Smartphone samsung = new Samsung(numero: "912345678", modelo: "S24 Ultra", imei: "123456789", memoria: 64);
samsung.Ligar();
samsung.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone Apple: ");
Smartphone apple = new Apple(numero: "998765432", modelo: "iPhone 16 Pro Max", imei: "987654321", memoria: 1024);
apple.ReceberLigacao();
apple.InstalarAplicativo("LinkedIn");
Console.WriteLine("");