using Godot;
using System;
using System.Collections;

[GlobalClass]
public partial class Card : Resource
{
	[Export] public string Id { get; set; } = string.Empty;
    [Export] public string Suit { get; set; } = string.Empty;
    [Export] public string Name { get; set; } = string.Empty;
    [Export] public Godot.Collections.Array<int> EffectsId { get; set; }
	[Export] public Texture2D Img { get; set; }
	[Export] public string Desc { get; set; } = string.Empty;

    public Card() 
	{
		this.Id = string.Empty;
        this.Suit = string.Empty;
		this.Name = string.Empty;
		this.EffectsId = new Godot.Collections.Array<int>();
		this.Img = null;
		this.Desc = string.Empty;
    }

	public Card(string id, string name, string suit, Godot.Collections.Array<int> effects, Texture2D img)
	{
        // Comprobamos que ningun parametro sea nulo o vacio
        // Si un parametro es nulo o vacio lanzamos una expecion personalalizada para depurar mas facilmente
		if (string.IsNullOrEmpty(id)) throw new ArgumentException("NULL CARD ID");
		if (string.IsNullOrEmpty(name)) throw new ArgumentException("NULL CARD NAME");
		if (string.IsNullOrEmpty(suit)) throw new ArgumentException("NULL CARD SUIT");
		if (effects == null) throw new ArgumentException("NO CARD EFFECTS");
		if (img == null) throw new ArgumentException("NO CARD IMG");

		this.Id = id;
		this.Name = name;
		this.Suit = suit;
		this.EffectsId = effects;
		this.Img = img;



        /*
		const int NoEffectId = 1;
		
		if (!hasNoEffect)
		{
			var sb = new System.Text.StringBuilder();
			for (int i = 0; i < effects.Count; i++)
			{
				if (effects[i] == NoEffectId) 
				{
					hasNoEffect = true;
					break;
				 }

				var effectDesc = EffectDictionary.GetEffectById(effects[i])?.Desc;
				if (!string.IsNullOrWhiteSpace(effectDesc))
					sb.Append(" - ").Append(effectDesc).AppendLine();
			}

			if (hasNoEffect && effects.Count > 1) 
				trow new ArgumentException("CARD CAN'T HAVE NO EFFECT AND OTHER EFFECTS AT THE SAME TIME");

			Desc = sb.ToString();
		}
		*/

    }

    public int GetValor() 
	{
		return Name switch
		{
			/* 
				El controlador tiene un contador de ases y cada vez que te pasas 
			de 21 resta 10 transformandolo en un 1 :)
			*/
			
			"As" => 11, 
			"K" or "Q" or "J" => 10,
			_ => int.TryParse(Name, out int resultado) ? resultado : 0
		};
	}
}
