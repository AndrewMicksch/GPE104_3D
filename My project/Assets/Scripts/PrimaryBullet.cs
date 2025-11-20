using UnityEngine;

public class PrimaryBullet : BulletClass
{
    public float damageDone;
    public float shootSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Bullet()
    {

    }
    void Update()
    {
        Shoot(shootSpeed);
        OutofBounds();
    }
    void OnTriggerEnter(Collider other)
    {
        HealthComp otherHealth = other.gameObject.GetComponent<HealthComp>();
        if(otherHealth != null)
        {
            otherHealth.TakeDamage(damageDone);
            GameObject.Destroy(gameObject);
        }
    }
    void OutofBounds()
    {
        if (transform.position.x <= LevelManager.level.minX || transform.position.y <= LevelManager.level.minY || transform.position.z <= LevelManager.level.minZ || transform.position.x >= LevelManager.level.maxX || transform.position.y >= LevelManager.level.maxY || transform.position.z >= LevelManager.level.maxZ)
        {
            Destroy(gameObject);
        }
    }

    void Shoot (float shootSpeed)
    {
        transform.position = transform.position + (transform.forward * shootSpeed) * Time.deltaTime;
    }
}
