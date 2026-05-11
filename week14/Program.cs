//Task1
public void CalculateDamage(int[] attackDamages, int attackIndex, int playerArmor)
{
    Console.WriteLine("Starting damage calculation...");

    try
    {
        int incomingDamage = attackDamages[attackIndex];
        int netDamage = incomingDamage / playerArmor;

        Console.WriteLine($"Player took {netDamage} damage!");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("CRITICAL HIT: Armor is 0!");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("ERROR: Invalid attack index!");
    }
    finally
    {
        Console.WriteLine("Saving combat logs to file...");
    }
}
//Task2
public class NetworkManager
{
    public void ParseServerPacket(string[] packetData, int uiScale, GameManager manager)
    {
        Console.WriteLine("Parsing incoming server packet...");

        try
        {
            string scoreText = packetData[3];
            int playerScore = int.Parse(scoreText);
            int scaledScore = playerScore / uiScale;

            manager.UpdateUI(scaledScore);

            Console.WriteLine("Packet parsed successfully!");
        }

        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("ERROR: Incomplete packet received!");
        }

        catch (FormatException)
        {
            Console.WriteLine("ERROR: Packet data is corrupted!");
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("ERROR: Cannot scale UI by zero!");
        }

        catch (NullReferenceException)
        {
            Console.WriteLine("ERROR: GameManager is missing in the scene!");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"CRITICAL: Unknown error occurred {ex.Message}");
        }

        finally
        {
            Console.WriteLine("Packet processing cycle finished.\n");
        }
    }
}
//Task3
public class NetworkManager
{
    public void ParseServerPacket(string[] packetData, int uiScale, GameManager manager)
    {
        Console.WriteLine("Parsing incoming server packet...");

        try
        {
            string scoreText = packetData[3];
            int playerScore = int.Parse(scoreText);
            int scaledScore = playerScore / uiScale;

            manager.UpdateUI(scaledScore);

            Console.WriteLine("Packet parsed successfully!");
        }

        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("ERROR: Incomplete packet received!");
        }

        catch (FormatException)
        {
            Console.WriteLine("ERROR: Packet data is corrupted!");
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("ERROR: Cannot scale UI by zero!");
        }

        catch (NullReferenceException)
        {
            Console.WriteLine("ERROR: GameManager is missing in the scene!");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"CRITICAL: Unknown error occurred {ex.Message}");
        }

        finally
        {
            Console.WriteLine("Packet processing cycle finished.\n");
        }
    }
}
public class NetworkManager
{
    public void ParseServerPacket(string[] packetData, int uiScale, GameManager manager)
    {
        Console.WriteLine("Parsing incoming server packet...");

        try
        {
            string scoreText = packetData[3];
            int playerScore = int.Parse(scoreText);
            int scaledScore = playerScore / uiScale;

            manager.UpdateUI(scaledScore);

            Console.WriteLine("Packet parsed successfully!");
        }

        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("ERROR: Incomplete packet received!");
        }

        catch (FormatException)
        {
            Console.WriteLine("ERROR: Packet data is corrupted!");
        }

        catch (DivideByZeroException)
        {
            Console.WriteLine("ERROR: Cannot scale UI by zero!");
        }

        catch (NullReferenceException)
        {
            Console.WriteLine("ERROR: GameManager is missing in the scene!");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"CRITICAL: Unknown error occurred {ex.Message}");
        }

        finally
        {
            Console.WriteLine("Packet processing cycle finished.\n");
        }
    }
}
//Task3
public class InventoryFullException : Exception
{
    public InventoryFullException(string message) : base(message)
    {
    }
}
public class Inventory
{
    private int maxCapacity = 5;
    private int currentItemCount = 0;

    public void AddItem(string itemName)
    {
        if (currentItemCount >= maxCapacity)
        {
            throw new InventoryFullException("Your bag is full! Cannot add item.");
        }

        currentItemCount++;

        Console.WriteLine(itemName + " was added.");
    }
}
public class Program
{
    public static void Main()
    {
        Inventory playerInventory = new Inventory();

        try
        {
            playerInventory.AddItem("Iron Sword");
            playerInventory.AddItem("Health Potion");
            playerInventory.AddItem("Wooden Shield");
            playerInventory.AddItem("Leather Boots");
            playerInventory.AddItem("Magic Wand");
            playerInventory.AddItem("Gold Ring");
        }

        catch (InventoryFullException ex)
        {
            Console.WriteLine("[UI Message]: " + ex.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine("System Error: " + ex.Message);
        }
    }
}