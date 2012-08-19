using System.Xml.Linq;

using NUnit.Framework;

using TextAdventure.Engine.Objects;
using TextAdventure.Engine.Serializers.Xml;

namespace TextAdventure.Engine.UnitTests.Serializers.Compact
{
	public static class WorldSerializerTester
	{
		[TestFixture]
		public class When_serializing_and_deserializing_instance : WorldSerializerTestFixture
		{
			[Test]
			public void Must_serialize_and_deserialize_correctly()
			{
				XElement worldElement = XElement.Parse(SerializerResources.World);
				World world = WorldSerializer.Instance.Deserialize(worldElement);

				byte[] serializedData = Engine.Serializers.Compact.WorldSerializer.Instance.Serialize(world);
				World deserializedWorld = Engine.Serializers.Compact.WorldSerializer.Instance.Deserialize(serializedData);

				Assert(deserializedWorld);
			}
		}
	}
}