using Robust.Shared.Prototypes;
namespace Content.Shared._DV.Magic.Components;

[RegisterComponent]
public sealed partial class SpellCastingComponent : Component
{
    [DataField]
    public float MaxSp = 100;

    [DataField]
    public float CurrentSp = 100;

    [DataField]
    public float SpRegen = 0.25;
}
