using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{
    GameObject player;
    //speed of enemy
    public float chasespeed = 5.0f;
    //how close player has to be to chase
    public float chasetriggerdistance = 10f;
    public bool returnHome = true;
    Vector3 home;
    float timer; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        home = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 chasedir = player.transform.position - transform.position;
        if (chasedir.magnitude < chasetriggerdistance)
        {
            chasedir.Normalize();
            GetComponent<Rigidbody2D>().velocity = chasedir * chasespeed;
            chasespeed = (chasespeed + Time.deltaTime);
        }
        else if (returnHome)
        { 
            Vector3 homedir = home - transform.position;
            if(homedir.magnitude > 0.2f)
            {

           
            homedir.Normalize();
            GetComponent<Rigidbody2D>().velocity = homedir * chasespeed;
            }
           
        } 
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
    }
}
