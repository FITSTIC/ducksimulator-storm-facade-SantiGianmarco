/// <summary>
/// Classe base di tutte le papere
/// </summary>
public abstract class Duck
{
    /// <summary>
    /// Nome del tipo di papera
    /// </summary>
    /// <returns>Il nome della papera</returns>
    public abstract string Name {get;}

    /// <summary>
    /// Direzione che la papera ha preso
    /// </summary>
    /// <returns></returns>
    public Direction CurrentDirection {get; set;}

    /// <summary>
    /// Mostra una frase con la quale la papera si presenta
    /// </summary>
    /// <returns>La presentazione della papera</returns>
    public string Display()
    {
        return $"This is a {Name}";
    }
}

/// <summary>
/// Interfaccia che permette di volare
/// </summary>
public interface IFlyable
{
    /// <summary>
    /// Totale dei metri percorsi volando
    /// </summary>
    /// <returns></returns>
    double TotalFly { get; }
    /// <summary>
    /// Azione volo
    /// </summary>
    /// <param name="meters">metri da fare volando</param>
    void Fly(double meters);
}

/// <summary>
/// Interfaccia che permette di nuotare
/// </summary>
public interface ISwimable
{
    /// <summary>
    /// Totale dei metri percorsi nuotando
    /// </summary>
    /// <returns></returns>
    double TotalSwim { get; }
    /// <summary>
    /// Azione nuoto
    /// </summary>
    /// <param name="meters">metri da fare nuotando</param>
    void Swim(double meters);
}

/// <summary>
/// Interfaccia che permette di fare Quack
/// </summary>
public interface IQuackable
{
    /// <summary>
    /// Azione di emettere il verso Quack
    /// </summary>
    /// <returns></returns>
    string Quack();
}