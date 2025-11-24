using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager level;

    public float minX;
    public float minY;
    public float minZ;
    public float maxX;
    public float maxY;
    public float maxZ;

    public Transform player;

    void Awake()
    {
        if (level == null)
        {
            level = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SkyLimit();
    }

    public void SkyLimit()
    {
        if (player != null)
        {
            
            if (player.transform.position.y >= maxY)
            {
                player.transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
            }
        }
    }
}
