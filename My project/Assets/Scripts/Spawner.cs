using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Spawned Objects")]
    public GameObject player;
    public GameObject healCapsule;
    public GameObject uFO;
    public GameObject meteor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnThings();
    }

    public void SpawnThings()
    {
        if (player != null)
        {
            if (player.activeSelf)
            {

            }
        }
        //if Spawner is exclusively for healing use this function to spawn a heal every 20 seconds.
        if (healCapsule != null && (uFO == null || meteor == null))
        {

        }
        //if spawner is used for spawning ufos & meteors use this one to spawn one of them randomly every 10 seconds as long as it wouldn't put it too far above the cap. 
        //TODO: set up a max ufo and meteor count in the Gamemanager
        if (meteor != null && uFO != null)
        {
            
        }
    }
}
