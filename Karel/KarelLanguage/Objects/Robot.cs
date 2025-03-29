using System.Runtime.Serialization;
using LanguageKarel.Models;

namespace KarelLanguage.Objects;

/// <summary>
/// Třída reprezentující robota Karla.
/// </summary>
[DataContract]
public class Robot
{
    /// <summary>
    /// Aktuální pozice robota.
    /// </summary>
    [DataMember]
    public Position Position { get; set; }

    /// <summary>
    /// Aktuální směr, kterým je robot otočen.
    /// </summary>
    [DataMember]
    public Direction Direction { get; set; }

    /// <summary>
    /// Počet značek (beepers) v batohu robota.
    /// </summary>
    [DataMember]
    public int BeepersInBag { get; set; }

    /// <summary>
    /// Inicializuje novou instanci třídy Robot s danou pozicí, směrem a počtem značek v batohu.
    /// </summary>
    /// <param name="startPos">Počáteční pozice robota.</param>
    /// <param name="startDir">Počáteční směr robota.</param>
    /// <param name="beepersInBag">Počet značek v batohu (výchozí hodnota je 999).</param>
    public Robot(Position startPos, Direction startDir, int beepersInBag = 999)

    {
        Position = startPos;
        Direction = startDir;
        BeepersInBag = beepersInBag;
    }

    /// <summary>
    /// Resetuje pozici, směr a počet značek v batohu robota.
    /// </summary>
    /// <param name="x">Nová x-ová souřadnice pozice.</param>
    /// <param name="y">Nová y-ová souřadnice pozice.</param>
    /// <param name="direction">Nový směr robota.</param>
    /// <param name="beepersInBag">Nový počet značek v batohu (výchozí hodnota je 999).</param>
    public void Reset(int x, int y, Direction direction, int beepersInBag = 999)
    {
        Position = new Position(x, y);
        Direction = direction;
        BeepersInBag = beepersInBag;
    }

    /// <summary>
    /// Vrátí pozici, na kterou se robot přesune při dalším kroku.
    /// </summary>
    /// <returns>Nová pozice robota po kroku.</returns>
    public Position GetNextPosition()

    {
        return Direction switch
        {
            Direction.North => Position with { Y = Position.Y - 1 },
            Direction.South => Position with { Y = Position.Y + 1 },
            Direction.East => Position with { X = Position.X + 1 },
            Direction.West => Position with { X = Position.X - 1 },
            _ => Position
        };
    }

    /// <summary>
    /// Posune robota o jeden krok vpřed.
    /// </summary>
    public void MoveForward()
    {
        Position = GetNextPosition();
    }

    /// <summary>
    /// Otočí robota doleva.
    /// </summary>
    public void TurnLeft()

    {
        Direction = Direction switch
        {
            Direction.North => Direction.West,
            Direction.West => Direction.South,
            Direction.South => Direction.East,
            Direction.East => Direction.North,
            _ => Direction
        };
    }

    public override string ToString()
    {
        return $"Robot {Position} pointing {Direction}";
    }
}

