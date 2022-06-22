using TareaBilletera;

var Billetera1 = new Billetera();
var segundaBilletera = new Billetera();
var nuevaBilletera = new Billetera();
Console.WriteLine("Bienvenido a su billetera...");
Console.WriteLine(" ");
Console.WriteLine("Empecemos a sumar los billetes:");
Console.WriteLine("Ingrese la cantidad de BILLETES DE 10");
Billetera1.BilletesDe10 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 20");
Billetera1.BilletesDe20 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 50");
Billetera1.BilletesDe50 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 100");
Billetera1.BilletesDe100 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 200");
Billetera1.BilletesDe200 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 500");
Billetera1.BilletesDe500 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 1000");
Billetera1.BilletesDe1000 = int.Parse(Console.ReadLine());


Console.WriteLine($"La suma total de su Billetera es: ${Billetera1.Total()}");
Console.WriteLine("******************************");
Console.WriteLine("Ahora su segunda billetera");

Console.WriteLine("Ingrese la cantidad de BILLETES DE 10");
segundaBilletera.BilletesDe10 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 20");
segundaBilletera.BilletesDe20 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 50");
segundaBilletera.BilletesDe50 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 100");
segundaBilletera.BilletesDe100 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 200");
segundaBilletera.BilletesDe200 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 500");
segundaBilletera.BilletesDe500 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de BILLETES DE 1000");
segundaBilletera.BilletesDe1000 = int.Parse(Console.ReadLine());


Console.WriteLine($"La suma total de su Segunda Billetera es: ${segundaBilletera.Total()}");
Console.WriteLine("******************************");

nuevaBilletera = Billetera1.Combinar(segundaBilletera);
Billetera1.VaciarBilletera();
segundaBilletera.VaciarBilletera();
Console.WriteLine($"La tercera Billetera tiene...${nuevaBilletera.Total()}");


Console.WriteLine("Oh no! Sus dos billeteras anteriores se han quedado sin dinero... :(");


Console.WriteLine($"La suma total de su Primera  Billetera es: ${Billetera1.Total()}");


Console.WriteLine($"La suma total de su Segunda  Billetera es: ${segundaBilletera.Total()}");
