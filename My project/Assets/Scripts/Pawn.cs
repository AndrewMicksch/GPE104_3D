using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Components")]
    public Rigidbody body;
    public HealthComp health;
    public Death death;
    private Transform spawnPosition;
    public GameObject spawnPoint;
    private Transform playerPos;
    public GameObject bulletType1;

    [Header("Player")]
    public bool isPlayer;

    [Header("Movement")]
    public float moveSpeed;
    public float baseSpeed;
    public float rotateSpeed;
    public float booster;
    public float turnSpeed;
    //public float iFramesLength;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        health = GetComponent<HealthComp>();
        death = GetComponent<Death>();
        playerPos = GetComponentInParent<Transform>(playerPos);

        if (isPlayer)
        {
            GameManager.core.activePlayer = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveTowards (Transform playerPos)
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPos.position, (moveSpeed * Time.deltaTime));
        transform.LookAt(playerPos);
    }

    public void MoveForward (float moveSpeed)
    {
        body.AddForce(transform.forward * moveSpeed);
    }
    public void MoveBackwards(float moveSpeed)
    {
        body.AddForce(transform.forward * -moveSpeed);
    }
    public void Brakes(float moveSpeed)
    {
        body.linearVelocity = Vector3.zero;
    }
    public void rotateLeft(float rotateSpeed)
    {
        transform.Rotate(0.0f, -rotateSpeed * Time.deltaTime, 0.0f );
    }
    public void rotateRight(float rotateSpeed)
    {
        transform.Rotate(0.0f, rotateSpeed * Time.deltaTime, 0.0f);
    }
    public void tiltUp(float rotateSpeed)
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0.0f, 0.0f);

    }
    public void tiltDown(float rotateSpeed)
    {
        transform.Rotate(-rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
    }
    public void tiltLeft(float rotateSpeed)
    {
        transform.Rotate(0.0f, 0.0f, rotateSpeed * Time.deltaTime);
    }
    public void tiltRight(float rotateSpeed)
    {
        transform.Rotate(0.0f, 0.0f, -rotateSpeed * Time.deltaTime);
    }

    public void FireBullet1()
    {
        spawnPosition = spawnPoint.GetComponent<Transform>();
        GameObject tempBull;
        tempBull = Instantiate(bulletType1, spawnPosition.position, transform.rotation) as GameObject;
        if(tempBull != null)
        {
            Pawn bullComponent = tempBull.GetComponent<Pawn>();
            tempBull.transform.parent = GameManager.core.levelOne.transform;
        }
    }
}
