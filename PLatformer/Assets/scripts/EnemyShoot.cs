using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject prefab;
    public float shootspeed = 10f;
    public float bulletlife = 2f;
    public float shootdelay = 1f;
    float timer = 0;
    GameObject player;
    public float AimSight = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootdir = player.transform.position - transform.position;
        if (shootdir.magnitude > AimSight && timer > shootdelay)
        {
            timer = 0;
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootdir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootdir * shootspeed;
            Destroy(bullet, bulletlife);
        }
    }
}
//i am the one who knocks