using Ardalis.SmartEnum;

namespace Discordcs.Core.Enums
{
    public class PremiumTypesEnum : SmartEnum<PremiumTypesEnum, uint>
    {
		public static readonly PremiumTypesEnum NITRO_CLASSIC = new("Nitro classic", 1 << 0);
		public static readonly PremiumTypesEnum NITRO = new("Nitro", 1 << 1);
        private PremiumTypesEnum(string name, uint value) : base(name, value)
		{

		}
    }
}