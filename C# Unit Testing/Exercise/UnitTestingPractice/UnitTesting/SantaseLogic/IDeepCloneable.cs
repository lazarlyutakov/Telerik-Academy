namespace SantaseLogic
{
    public interface IDeepCloneable<out T>
    {
        T DeepClone();
    }
}