using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ardalis.SmartEnum;
using Ardalis.SmartEnum.JsonNet;
using Discordcs.Core.Enums;
using Newtonsoft.Json;

namespace Discordcs.Core.Models
{
    public class SmartEnumArrayValueConverter<TEnum> : JsonConverter<TEnum[]>
		where TEnum : BitFlagSmartEnum<TEnum>
    {
        public override TEnum[] ReadJson(JsonReader reader, Type objectType, TEnum[] existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			try
			{
				TEnum[] ret = BitFlagSmartEnum<TEnum>.FlagsToArray((ulong) (Convert.ChangeType(reader.Value, typeof(ulong)) ?? 0));
				return ret;
			}
			catch (Exception e)
			{
				throw new JsonSerializationException($"Error converting {reader.Value ?? "Null"} to {objectType.Name}.", e);
			}
		}

		public override void WriteJson(JsonWriter writer, TEnum[] value, JsonSerializer serializer)
		{
			if (value is null)
				writer.WriteValue(0);
			else
				writer.WriteValue(BitFlagSmartEnum<TEnum>.ArrayToFlags(value));
		}
    }
}