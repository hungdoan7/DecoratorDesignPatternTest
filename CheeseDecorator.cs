using System;

public class CheeseDecorator : Decorator
{
    public CheeseDecorator(IMilkTea milkTea) : base(milkTea)
    {

    }

    public override double charging()
    {
        return this.milkTea.charging() + 5;
    }

    public override string getInfo()
    {
      return this.milkTea.getInfo() + this.AddingCheese();
    }

    public string AddingCheese()
    {
       return ", adding some socola";
    }

    public override IMilkTea unwrapping()
    {
        return this.milkTea;
    }
}