using System;
namespace TareaBilletera
{
	public class Billetera
	{
		public int BilletesDe10 { get; set; }
		public int BilletesDe20 { get; set; }
		public int BilletesDe50 { get; set; }
		public int BilletesDe100 { get; set; }
		public int BilletesDe200 { get; set; }
		public int BilletesDe500 { get; set; }
		public int BilletesDe1000 { get; set; }


		public void VaciarBilletera() 
	
	
	{
			 BilletesDe10 = 0;
			 BilletesDe20 = 0;
			 BilletesDe50 = 0;
			BilletesDe100 = 0;
			 BilletesDe200 = 0;
			BilletesDe500 = 0;
			 BilletesDe1000 = 0;

	}



		public decimal Total()
		{
			int de10 = BilletesDe10 * 10;
			int de20 = BilletesDe20 * 20;
			int de50 = BilletesDe50 * 50;
			int de100 = BilletesDe100 * 100;
			int de200 = BilletesDe200 * 200;
			int de500 = BilletesDe500 * 500;
			int de1000 = BilletesDe1000 * 1000;
			int suma = de10 + de20 + de50 + de100 + de200 + de500 + de1000;
			decimal d = new decimal(suma);
			return d;
		}


		public Billetera Combinar(Billetera segundaBilletera)
	{
			Billetera nuevaBilletera = new Billetera();


			int B10 = BilletesDe10 + segundaBilletera.BilletesDe10;
			int B20 = BilletesDe20 + segundaBilletera.BilletesDe20;
			int B50 = BilletesDe50 + segundaBilletera.BilletesDe50;
			int B100 = BilletesDe100 + segundaBilletera.BilletesDe100;
			int B200 = BilletesDe200 + segundaBilletera.BilletesDe200;
			int B500 = BilletesDe500 + segundaBilletera.BilletesDe500;
			int B1000 = BilletesDe1000 + segundaBilletera.BilletesDe1000;

			nuevaBilletera.BilletesDe10 = B10;
			nuevaBilletera.BilletesDe20 = B20;
			nuevaBilletera.BilletesDe50 = B50;
			nuevaBilletera.BilletesDe100 = B100;
			nuevaBilletera.BilletesDe200 = B200;
			nuevaBilletera.BilletesDe500 = B500;
			nuevaBilletera.BilletesDe1000 = B1000;
	       
			
			
			return nuevaBilletera;
			
			int cero = 0;

		
			
			segundaBilletera.BilletesDe10 = cero;
			segundaBilletera.BilletesDe20 = cero;
			segundaBilletera.BilletesDe50 = cero;
			segundaBilletera.BilletesDe100 = cero;
			segundaBilletera.BilletesDe200 = cero;
			segundaBilletera.BilletesDe500= cero;
			segundaBilletera.BilletesDe1000 = cero;

		}


	}
}

