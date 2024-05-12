using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "71988884545", modelo: "N3310", imei: "369852147147852369", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Snake Game 97");
nokia.ReceberLigacao();

Console.WriteLine();

Smartphone iphone = new Iphone(numero: "71977772525", modelo: "IPHONE2G", imei: "963258741741258963", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Angly Birds Game");
iphone.ReceberLigacao();