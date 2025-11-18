using UnityEngine;

public class HealthPickUp : MonoBehaviour
{

    public float healAmount;
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
        HealthComp otherHealth = other.gameObject.GetComponent<HealthComp>();
        if (otherHealth != null && otherHealth.currentHP != otherHealth.maxHP)
        {
            otherHealth.Heal(healAmount);
            
        }
    }
}
