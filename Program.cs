using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
Iphone iphone = new Iphone("123456789", "Nokia 3310", "123456789012345", 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Snake");
