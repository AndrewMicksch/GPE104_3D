using Unity.VisualScripting;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    public Transform player;
    public Transform camPos;
    public float speed;
    //how close the camera can get
    public float currentOffset;
    public float followOffsetMax;
    public float followOffsetMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if (player != null && camPos !=null)
        {
            transform.LookAt(player.position, Vector3.up);
            speed *= Time.deltaTime;
            transform.position = Vector3.MoveTowards(camPos.position, transform.position, speed);
            //if (Vector3.Distance(transform.position, camPos.position) < currentOffset)
            //{
            //     transform.position = new Vector3(camPos.transform.position.x , (camPos.transform.position.y + currentOffset), (camPos.transform.position.z - currentOffset));
            //}
        }
        else
        {
            transform.LookAt(player.position, Vector3.up);
        }
    }
}
