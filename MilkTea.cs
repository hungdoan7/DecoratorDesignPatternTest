public abstract class MilkTea : IMilkTea
{
    protected string Name;
    protected double Cost;

    public string getName ()
    {
        return this.Name;
    }

    public double getCost()
    {
        return this.Cost;
    }

    public double charging()
    {
         return this.Cost;
    }


    public string getInfo()
    {
        return this.getName();
    }

    public IMilkTea unwrapping()
    {
        return this;
    }
}