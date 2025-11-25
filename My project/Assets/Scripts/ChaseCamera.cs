using Unity.Mathematics;
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
            transform.LookAt(player.position, transform.up);
            if (Vector3.Distance(transform.position, camPos.position) <= 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, camPos.position, (speed * Time.deltaTime));
            }
            
            //if (Vector3.Distance(transform.position, camPos.position) < currentOffset)
            //{
            //     transform.position = new Vector3(camPos.transform.position.x , (camPos.transform.position.y + currentOffset), (camPos.transform.position.z - currentOffset));
            //}
        }
        else
        {
            transform.LookAt(player.position);
        }
    }
}
