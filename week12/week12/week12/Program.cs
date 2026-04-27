public class EnemyNPC
{
    public string Name { get; set; }
    public int AttackPower { get; set; }
}
public class EnemyAI
{
    public void ChasePlayer(EnemyNPC enemy)
    {
        // AI Pathfinding algorithms to find and follow the player...
    }
}
public class EnemyLootSystem
{
    public void DropLoot(EnemyNPC enemy)
    {
        // Spawning gold or items on the ground when the enemy dies...
    }
}
public class EnemyUI
{
    public void RenderHealthBar(EnemyNPC enemy)
    {
        // Drawing UI elements on the screen to show enemy's remaining health...
    }
}