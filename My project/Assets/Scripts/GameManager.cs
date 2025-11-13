using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager core;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if( core == null)
        {
            core = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
