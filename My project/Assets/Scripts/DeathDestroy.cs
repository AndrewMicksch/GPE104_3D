using UnityEngine;

public class DeathDestroy : Death
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool player;
    public override void Die()
    {
        Destroy(gameObject);
    }
}
