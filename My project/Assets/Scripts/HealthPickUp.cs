using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    [Header("Health")]
    public float minHeal;
    public float maxHeal;
    private float healAmount;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.core.heals.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        healAmount = Random.Range(minHeal, maxHeal);
        HealthComp otherHealth = other.gameObject.GetComponent<HealthComp>();
        if (otherHealth != null && otherHealth.currentHP != otherHealth.maxHP)
        {
            otherHealth.Heal(healAmount);
            Destroy(gameObject);
        }
    }
    void OnDestroy()
    {
        GameManager.core.heals.Remove(this);
    }
}
