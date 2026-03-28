using Godot;
using System;

public abstract partial class Effect : Resource
{
	[Export] public int Id { get; private set; } //Serán potencias de 2 para facilitar el diccionario de sinergias
	[Export] public string Name { get; private set; } = string.Empty;
	[Export] public string Desc { get; private set; } = string.Empty;

	public Effect(int id, string name, string desc)
	{
		if (id == 0) 
			throw new ArgumentException(GameConstants.ErrorMessages.EffectIdCannotBeZero);
		
		if (string.IsNullOrEmpty(name)) 
			throw new ArgumentException(GameConstants.ErrorMessages.NullEffectName);

		if (string.IsNullOrEmpty(desc)) 
			throw new ArgumentException(GameConstants.ErrorMessages.NullEffectDescription);
        
		this.Id = id;
		this.Name = name;
		this.Desc = desc;
	}

	public abstract void Apply(Card source);
}
