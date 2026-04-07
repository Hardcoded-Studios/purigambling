public static class GameConstants
{
	public static class Effect
	{
		//EffectCatalog
		public const int EffectCount = 1;

        //NoEffect
        public const int NoEffectId = 1;
		public const string NoEffectName = "No Effect";
		public const string NoEffectDescription = "This card has no special effect.";

		//Other Effects
	}

	public static class Card
	{

	}
	public static class ErrorMessages
	{
		public const string CardCannotHaveNoEffectAndOtherEffects = "CARD CAN'T HAVE NO EFFECT AND OTHER EFFECTS AT THE SAME TIME";
        public const string NullCardId = "NULL CARD ID";
        public const string NullCardName = "NULL CARD NAME";
        public const string NullCardSuit = "NULL CARD SUIT";
        public const string NoCardEffects = "NO CARD EFFECTS";
        public const string NoCardImg = "NO CARD IMG";
        public const string EffectIdCannotBeZero = "EFFECT ID CAN'T BE 0";
        public const string NullEffectName = "NULL EFFECT NAME";
        public const string NullEffectDescription = "NULL EFFECT DESCRIPTION";
        public const string InvalidEffectId = "INVALID EFFECT ID {0}";
    }

}
