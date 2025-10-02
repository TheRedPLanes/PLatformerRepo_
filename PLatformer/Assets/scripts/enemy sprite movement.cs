using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspritemovement : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xvelocity = Input.GetAxis("Horizontal");
        float yvelocity = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("x", xvelocity);
        GetComponent<Animator>().SetFloat("y", yvelocity);
    }
}
