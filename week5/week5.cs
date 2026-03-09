public Text goldText;
public Text crystalText;
public Text foodText;

void UpdateResourceText(TextReader resourceText, int amount)
{
    resourceText.text = "Amount: " + amount.ToString();
}

void PlaySound(AudioClip clip) 
{
    AudioSource audio = GetComponent<AudioSource>(); 
    audio.clip = clip;
    audio.Play();
}

void Jump() 
{
    PlaySound(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot() 
{
    PlaySound(shootSound);
    Instantiate(bullet);
}

AudioSource myAudioSource;

void Start() 
{
    myAudioSource = GetComponent<AudioSource>();
}

void PlaySound(AudioClip clip) 
{
    myAudioSource.clip = clip;
    myAudioSource.Play();
}
public interface IWeapon 
{
    void Fire();
    void Reload();
}

public class Pistol : IWeapon 
{
    public void Fire() 
    {
        Console.WriteLine("Pistol fired.");
    }

    public void Reload() 
    {
        Console.WriteLine("Pistol reloaded.");
    }
}

public class PlayerStats 
{
    public float jumpForce = 5f;
}

public bool IsPlayerDead() 
{
    return health <= 0;
}

void CheckEnemy(string enemyType) 
{
    if (enemyType == "Goblin" || enemyType == "Orc" || enemyType == "Troll") 
    {
        Attack();
    } 
    else 
    {
        RunAway();
    }
}