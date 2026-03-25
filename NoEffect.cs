using Godot;
using System;

public sealed class NoEffect : Effect
{
    
    const int NoEffectId = 1;
    const string NoEffectName = "No Effect";
    const string NoEffectDescription = "This card has no special effect.";

    public NoEffect() : base(NoEffectId, NoEffectName, NoEffectDescription) { }
    public override void Apply(Card source) { }
}