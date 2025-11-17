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
        if (transform.position.x <= GameManager.core.minX || transform.position.y <= GameManager.core.minY || transform.position.z <= GameManager.core.minZ || transform.position.x >= GameManager.core.maxX || transform.position.y >= GameManager.core.maxY || transform.position.z >= GameManager.core.maxZ)
        {
            Destroy(gameObject);
        }
    }

    void Shoot (float shootSpeed)
    {
        transform.position = transform.position + (transform.forward * shootSpeed) * Time.deltaTime;
    }
}
