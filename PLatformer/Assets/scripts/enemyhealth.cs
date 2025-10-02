using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int health = 3;
    float maxHealth;
    public int dropchance = 100;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "playerbullet")
        {
            //destoys bullet
            Destroy(collision.gameObject);
            health--;
            if (health <= 0)
            {
                //kills it
                Destroy(gameObject);
                int r = Random.Range(1, 101);
                if(dropchance >=r)
                {
                    //drop item
                    Instantiate(prefab, transform.position, Quaternion.identity);
                    //sigma

                }
            }
        }
        if (collision.gameObject.tag == "playerswing")
        {
            //destoys bullet
            Destroy(collision.gameObject);
            health--;
            if (health <= 0)
            {
                //kills it
                Destroy(gameObject);
                int r = Random.Range(1, 101);
                if (dropchance >= r)
                {
                    //drop item
                    Instantiate(prefab, transform.position, Quaternion.identity);
                    //sigma

                }
            }
        }
        }
}

