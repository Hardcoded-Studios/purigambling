using Godot;
using System;

public sealed class NoEffect : Effect
{
	public NoEffect() : base(GameConstants.Effect.NoEffectId, GameConstants.Effect.NoEffectName, GameConstants.Effect.NoEffectDescription) { }
	public override void Apply(Card source) { }
}
