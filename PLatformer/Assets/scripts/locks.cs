using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locks : MonoBehaviour
{
    public int key = 0;
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "key")

        {
            key++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "locked")
        {
            if (key == 1)
            {
                key--;
                Destroy(collision.gameObject);
            }
        }
    }

}
