using System.Runtime.Serialization;

namespace LanguageKarel.Models;

/// <summary>
/// Třída reprezentující pozici v městě.
/// </summary>
/// <param name="X">Souřadnice X, tj. sloupec.</param>
/// <param name="Y">Souřadnice Y, tj. řádek.</param>
[DataContract]
public record struct Position(
    [property: DataMember] int X,
    [property: DataMember] int Y);

