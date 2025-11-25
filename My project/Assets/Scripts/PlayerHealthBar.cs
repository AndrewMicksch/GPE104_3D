using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public GameObject playerShip;
    public HealthComp playerHP;
    public Slider playerHPBar;
    public Image fill;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerShip == null)
        {
            playerShip = GameManager.core.activePlayer;
        }
        if (playerHP == null)
        {
            playerHP = playerShip.GetComponent<HealthComp>();
        }
        if (playerHP != null)
        {
            UpdateHealth();
        }
    }

    void UpdateHealth()
    {
        playerHPBar.value = playerHP.currentHP / playerHP.maxHP;
    }
}
