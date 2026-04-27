public interface IAttacktable
{
    void Attack();
}
public interface IReloadable
{
    void Reload();
}
public interface IAimable
{
    void AimDownSights();
}
public class SniperRifle : IAttacktable, IReloadable, IAimable
{
    public void Attack()
    {
        Console.WriteLine("Firing a high-caliber round!");
    }
    public void Reload()
    {
        Console.WriteLine("Loading a new magazine.");
    }
    public void AimDownSights()
    {
        Console.WriteLine("Looking through the 8x scope.");
    }
}
public class Sword : IAttacktable
{
    public void Attack()
    {
        Console.WriteLine("Swinging the sword!");
    }
}