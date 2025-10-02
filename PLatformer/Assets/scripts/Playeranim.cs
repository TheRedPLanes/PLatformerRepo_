using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeranim : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xinput = Input.GetAxis("Horizontal");
        float yinput = Input.GetAxis("Vertical");
        GetComponent<Animator>().SetFloat("x", xinput);
        GetComponent <Animator>().SetFloat("y", yinput);
    }
}
