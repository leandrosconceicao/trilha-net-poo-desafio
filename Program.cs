using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia cel1 = new ("82996704242", "1100", "imei", 100);
Iphone cel2 = new ("82996704242", "1100", "imei", 100);

cel1.InstalarAplicativo("Teste 1");
cel1.Ligar();
cel1.ReceberLigacao();

cel2.InstalarAplicativo("Teste 2");
cel2.Ligar();
cel2.ReceberLigacao();