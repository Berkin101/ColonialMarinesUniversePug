using Content.Shared.DoAfter;
using Robust.Shared.Map;
using Robust.Shared.Serialization;

namespace Content.Shared._RMC14.Entrenching;

[Serializable, NetSerializable]
public sealed partial class RazorwireDismantleDoAfterEvent : SimpleDoAfterEvent
{
    [DataField(required: true)]
    public NetCoordinates Coordinates;

    public RazorwireDismantleDoAfterEvent(NetCoordinates coordinates)
    {
        Coordinates = coordinates;
    }
}
