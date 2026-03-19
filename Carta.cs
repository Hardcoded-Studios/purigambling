using Godot;
using System;

[GlobalClass]
public partial class Carta : Resource
{
	[Export] public string Palo { get; set; }
	[Export] public string Nombre { get; set; }

	public int GetValor() 
	{
		return Nombre switch
		{
			/* 
			El controlador tiene un contador de ases y cada vez que te pasas 
			de 21 resta 10 transformandolo en un 1 :)
			*/
			
			"As" => 11, 
			"K" or "Q" or "J" => 10,
			_ => int.TryParse(Nombre, out int resultado) ? resultado : 0
		};
	}
}
