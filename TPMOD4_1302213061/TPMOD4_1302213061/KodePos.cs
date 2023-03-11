using System;

public class KodePos
{
	private enum Kelurahan{Batununggal, Kujangsari,Mengger,Wates,Cijaura,Jatisari,Margasari,Sekejati,Kebonwaru,Maleer,Samoja}
	private int[] Kode = { 40266 , 40287 , 40267 , 40256 , 40287 , 40286 , 40286 , 40286 , 40272 , 40274 , 40273 };
	public void GetKodePos()
	{
		for(int i = 0; i < Kode.Length; i++)
		{
			Console.WriteLine((Kelurahan)i + " " + Kode[i]);
		}
	}
}
