namespace Decorator.Interface
{
    public interface IBeverage
    {
        string Description { get; set; }

        string GetDescription();

        double Cost();
    }
}