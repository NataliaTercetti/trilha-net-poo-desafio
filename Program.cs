﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Chamando os métodos comuns da classe Smartphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "456789", modelo: "Modelo2", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");


