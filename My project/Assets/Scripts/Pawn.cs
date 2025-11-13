using UnityEngine;

public class Pawn : MonoBehaviour
{
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

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveForward (float moveSpeed)
    {
        transform.position += (transform.forward * moveSpeed) * Time.deltaTime;
    }
    public void MoveBackwards(float moveSpeed)
    {
        transform.position += (transform.forward * -moveSpeed) * Time.deltaTime;
    }
    public void turnLeft(float moveSpeed)
    {
        transform.position += (transform.forward * moveSpeed) * Time.deltaTime;
    }
    public void turnRight(float moveSpeed)
    {
        transform.position += (transform.forward * moveSpeed) * Time.deltaTime;
    }
}
