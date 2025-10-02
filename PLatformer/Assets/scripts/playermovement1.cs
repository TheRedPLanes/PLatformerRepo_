using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement1 : MonoBehaviour
{
    public float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //top down movement checking
        //vertcal and horizontal inputs
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        //push/move according to input
        //using rigidbody to move

        //combine x & y inputs
        Vector2 movedir = new Vector2(moveX, moveY);
        //actual movement
        GetComponent<Rigidbody2D>().velocity = movedir * 10;

    }
}
