﻿using Content.Server.StationEvents.Events;
using Robust.Shared.Prototypes;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Server.StationEvents.Components;

/// <summary>
/// Used an event that gifts the station with certian cargo
/// </summary>
[RegisterComponent, Access(typeof(CargoGiftsRule))]
public sealed class CargoGiftsRuleComponent : Component
{
    /// <summary>
    /// What is being sent
    /// </summary>
    [DataField("descr"), ViewVariables(VVAccess.ReadWrite)]
    public string Descr = "A bundle of gifts";

    /// <summary>
    /// Sender of the gifts
    /// </summary>
    [DataField("sender"), ViewVariables(VVAccess.ReadWrite)]
    public string Sender = "NanoTrasen";

    /// <summary>
    /// Destination of the gifts (who they get sent to on the station)
    /// </summary>
    [DataField("careof"), ViewVariables(VVAccess.ReadWrite)]
    public string Careof = "The Cargo Dept.";

    /// <summary>
    /// Cargo that you would like gifted to the station, with the quantity for each
    /// Use Ids from cargoProduct Prototypes
    /// </summary>
    [DataField("gifts"), ViewVariables(VVAccess.ReadWrite)]
    public Dictionary<string, int> Gifts = new Dictionary<string, int>();

    /// <summary>
    /// How much space (minimum) you want to leave in the order database for supply to actually do their work
    /// </summary>
    [DataField("orderSpaceToLeave"), ViewVariables(VVAccess.ReadWrite)]
    public int OrderSpaceToLeave = 5;

    /// <summary>
    /// Time until we consider next lot of gifts
    /// </summary>
    [DataField("timeUntilNextGifts"), ViewVariables(VVAccess.ReadWrite)]
    public float TimeUntilNextGifts = 10.0f;
}