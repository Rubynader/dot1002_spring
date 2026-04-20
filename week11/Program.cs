namespace RPGInteractQuest
{
    public interface IInteractable
    {
        void Interact();
    }
    public class Door : IInteractable 
    {
        public void Interact()
        {
           Console.WriteLine("The wooden door opens with a creaking sound.");
        }
    }
    public class NPC : IInteractable 
    {
        public void Interact()
        {
            Console.WriteLine("Greetings, traveler! I have a new quest for you.");
        }
    }
    public class Treasure Chest : IInteractable
    {
        private bool isOpened = false;
        public void Interact()
        {
            if (!isOpened)
            {
                Console.WriteLine("You opened the chest! You found 100 Gold and a Legendary Sword.");
                isOpened = true;
            }
            else 
            {
                Console.WriteLine("The chest is already empty. Look elsewwhere.");
            }
         }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Door myDoor = new Door();
        TreasureChest myChest = new TreasureChest();
        NPC myNPC = new NPC();
        List<IInteractable> interactablesWithinReach = new List<IInteractable>
        {
            myDoor,
            myChest,
            myNPC
        }
        Console.WriteLine("---Oyuncu E tuşuna basarak çevredeki nesnelerle etkileşimde giriyor---");
        for (int i = 0; i < interactablesWithinReach.Count; i++)
        {
            interactablesWithinReach[i].Interact();
        }
        Console.WriteLine("---Oyuncu sandıkla ikinic kez etkileşime girmeyi deniyor(Challenge)--- ");
        myChest.Interact();
        Console.ReadLine();
    }
}
