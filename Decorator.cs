public abstract class Decorator: IMilkTea
{
    public IMilkTea milkTea { get; set; }
    public Decorator(IMilkTea milkTea)
    {
        this.milkTea = milkTea;
    }

    public abstract double charging();

    public abstract string getInfo();

    public abstract IMilkTea unwrapping();
}