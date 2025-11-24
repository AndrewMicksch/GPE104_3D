using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    public bool isInstantKill;
    public float damageDone;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Death otherDeath = other.gameObject.GetComponent<Death>();
        if (isInstantKill == true && otherDeath != null)
        {
            HealthComp otherHealth = other.gameObject.GetComponent<HealthComp>();
            if (otherHealth != null)
            {
                otherDeath.Die();
            }
        }
        else
        {
            HealthComp otherHealth = other.gameObject.GetComponent<HealthComp>();
            if (otherHealth != null)
            {
                otherHealth.TakeDamage(damageDone);
            }
        }
    }
    
}
