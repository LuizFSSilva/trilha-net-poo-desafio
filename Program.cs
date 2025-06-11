using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia cel1 = new Nokia(numero: "99999-9999", modelo: "Nokia 3310", imei: "IAC070930191", memoria: 16);
Iphone cel2 = new Iphone(numero: "12345-6789", modelo: "Iphone 10", imei: "IAC99883456", memoria: 128);

System.Console.WriteLine("\nTeste NOKIA:");
cel1.InstalarAplicativo("Calculadora");
cel1.Ligar();
cel1.ReceberLigacao();

System.Console.WriteLine("\n\nTeste Iphone:");
cel2.InstalarAplicativo("Fruit Ninja");
cel2.Ligar();
cel2.ReceberLigacao();