using System;

public class SocolaDecorator : Decorator
{
    public SocolaDecorator(IMilkTea milkTea) : base(milkTea)
    {

    }

    public override double charging()
    {
        return this.milkTea.charging() + 15;
    }

    public override string getInfo()
    {
      return this.milkTea.getInfo() + this.AddingSocola();
    }

    public string AddingSocola()
    {
       return ", adding some socola";
    }

    public override IMilkTea unwrapping()
    {
        return this.milkTea;
    }
}