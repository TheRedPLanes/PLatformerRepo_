using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playershoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootspeed = 10f;
    public float bulletlife = 2f; 
    public float shootdelay = 1f;   
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
        if(Input.GetButton("Fire1") && timer > shootdelay )
        {
            timer = 0; 
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            Debug.Log(mousePos);
            mousePos.z = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mouseDir = mousePos - bullet.transform.position;
            mouseDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * shootspeed;
            Destroy(bullet, bulletlife);
        }
    }
}
