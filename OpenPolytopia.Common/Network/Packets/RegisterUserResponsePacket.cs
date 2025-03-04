namespace OpenPolytopia.Common.Network.Packets;

/// <summary>
/// Result of the registration
/// </summary>
/// <seealso cref="RegisterUserPacket"/>
public class RegisterUserResponsePacket : IPacket {
  public static RegisterUserResponsePacket Default() => new() { Ok = false };

  public required bool Ok;

  public void Serialize(List<byte> bytes) => Ok.Serialize(bytes);

  public void Deserialize(byte[] bytes) {
    var index = 0u;
    Ok.Deserialize(bytes, ref index);
  }
}
