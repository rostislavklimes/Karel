namespace Karel;

public class RobotKarel
{
    public int X { get; set; }
    public int Y { get; set; }
    public Smer Smer { get; set; }

    public void Krok()
    {


        switch (Smer)
        {
            case Smer.Sever:
                Y = Y - 1;
                break;

            case Smer.Vychod:
                X = X + 1;
                break;

            case Smer.Jih:
                Y = Y + 1;
                break;

            case Smer.Zapad:
                X = X - 1;
                break;
        }
    }

    public void Vlevo()
    {
        Smer = Smer.Zapad;

        switch (Smer) {
          case Smer.Sever:
            Smer = Smer.Zapad;
            break;

            case Smer.Vychod:
                Smer = Smer.Sever;
                break;

            case Smer.Jih:
                Smer = Smer.Vychod;
                break;

            case Smer.Zapad:
                Smer = Smer.Jih;
                break;
        }
   


}}
    

