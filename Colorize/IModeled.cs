namespace Colorize
{
    public interface IModeled<out T>
    {
        T GetViewModel();
    }
}
