using System;
using System.Numerics;

public static partial class EffectCatalog
{
    private static Effect[] _effects = new Effect[GameConstants.Effect.EffectCount];
    private static readonly object _lock = new object();

    public static Effect GetEffectById(int id)
    {
        if (id <= 0 || !BitOperations.IsPow2((uint)id))
            throw new ArgumentException(string.Format(GameConstants.ErrorMessages.InvalidEffectId, id));

        //Pasa el id a binario y cuenta el numero de 0s a partir de su id para obtener el exponente, ya que cada id es una potencia de 2.
        //Asi si el id es 1 (2^0) el indice sera 0, si el id es 2 (2^1) el indice sera 1, si el id es 4 (2^2) el indice sera 2, etc.
        int idx = BitOperations.TrailingZeroCount((uint)id);

        if (idx < 0 || idx >= GameConstants.Effect.EffectCount)
            throw new ArgumentOutOfRangeException(string.Format(GameConstants.ErrorMessages.InvalidEffectId, id));

        if (_effects[idx] == null)
        {
            lock (_lock) 
            { 
                if (_effects[idx] == null)
                _effects[idx] = CreateEffectById(id);
            }
        }
        return _effects[idx];
    }

    private static Effect CreateEffectById(int id)
    {
        return id switch
        {
            GameConstants.Effect.NoEffectId => new NoEffect(),
            //Otros efectos
            _ => throw new ArgumentException(string.Format(GameConstants.ErrorMessages.InvalidEffectId, id))
        };
    }
}
 