using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    //store variables = to the collected collectables
    public int coin = 0;
    public TMP_Text text;
    //determintion collection on collide
    //destroy collected to disable collection spam
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "coin" ) 

        {
            coin++;
            Destroy(collision.gameObject);
            text.text = "coins" + coin;
        }
     
        if (collision.gameObject.tag == "hurt" )
        {
           

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
