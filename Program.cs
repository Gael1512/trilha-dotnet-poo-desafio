using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia c1 = new Nokia("(81)9.9999-9999", "Nokia Mjolnir", "11111111", 120);
c1.Ligar();
c1.InstalarAplicativo("Whatsapp");

Console.WriteLine("--------------------------");

Console.WriteLine("Smartphone Iphone:");
Iphone c2 = new Iphone("(81)9.8888-8888", "Iphone 15", "222222222", 800);
c2.ReceberLigacao();
c2.InstalarAplicativo("Telegram");
