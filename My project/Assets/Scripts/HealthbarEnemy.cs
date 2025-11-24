using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;


public class HealthbarEnemy : MonoBehaviour
{
    public Slider healthBar;
    public Image fill;
    public HealthComp enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy = this.GetComponentInParent<HealthComp>();
        UpdateHealth();
    }

    void UpdateHealth()
    {
        healthBar.value = enemy.currentHP / enemy.maxHP;
    }
}
