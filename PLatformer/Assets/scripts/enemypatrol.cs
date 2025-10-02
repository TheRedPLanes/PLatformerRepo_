using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class enemypatrol : MonoBehaviour
{
    public Transform[] waypoints; //these are the waypoints
    public float speed; //movement speed of enemy patrol.
    public float waitTime; //time waited/spent at each waypoint
    public int currentWaypointindex = 0;
    private float waitTimer; 
    // Start is called before the first frame update
    void Start()
    {
        waitTimer = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, waypoints[currentWaypointindex].position) <0.1f)
        {
            if (waitTimer >= 0)
            {
                //move to next waypoint
                currentWaypointindex = (currentWaypointindex + 1) % waypoints.Length;
                waitTimer = waitTime;
            }
            else
            {
                waitTimer -= Time.deltaTime; //should reset timer(?)
            }
            
        }
        
       else
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                waypoints[currentWaypointindex].position,
                speed * Time.deltaTime
                ); //sad winky face lol
        }
    }
}
