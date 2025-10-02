using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermelee : MonoBehaviour
{
    public GameObject prefab;
    public float shootspeed = 0f;
    public float swinglife = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log(mousePos);
            mousePos.z = 0;
            GameObject swing = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mouseDir = mousePos - swing.transform.position;
            mouseDir.Normalize();
            swing.GetComponent<Rigidbody2D>().velocity = mouseDir * shootspeed;
            Destroy(swing, swinglife);
        }
    }
}
