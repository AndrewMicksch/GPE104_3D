using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeDecisions();
    }
    private void MakeDecisions()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.MoveForward(player.moveSpeed);
        }
    }
}
