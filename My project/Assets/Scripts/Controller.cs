using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn player;
    public Transform playerPos;
    public Pawn uFO;

    public bool enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            MakeDecisions();
        }
        if (enemy != false)
        {
            MakeEvilDecisions();
        }
    }
    private void MakeDecisions()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player.MoveForward(player.moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.MoveBackwards(player.moveSpeed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            player.Brakes(player.moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.rotateLeft(player.rotateSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.rotateRight(player.rotateSpeed);
        }
        if (Input.GetKey(KeyCode.I))
        {
            player.tiltUp(player.rotateSpeed);
        }
        if (Input.GetKey(KeyCode.K))
        {
            player.tiltDown(player.rotateSpeed);
        }
        if (Input.GetKey(KeyCode.J))
        {
            player.tiltLeft(player.rotateSpeed);
        }
        if (Input.GetKey(KeyCode.L))
        {
            player.tiltRight(player.rotateSpeed);
        }

        if (Input.GetKeyDown(KeyCode.U))
        {
            player.FireBullet1();
        }
    }

    private void MakeEvilDecisions()
    {
        if (playerPos != null && uFO != null)
        {
            uFO.MoveTowards(playerPos);
        }
    }
}
