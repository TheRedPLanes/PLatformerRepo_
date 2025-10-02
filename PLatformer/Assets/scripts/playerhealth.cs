using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class playerhealth : MonoBehaviour
{
    //store health.
    public float health = 10;
    float maxHealth;
    public Image healthbar;
    //if hit bad thing, take damage.
    //if health = >1, die (reload level)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bad")
        {
            health--;
            healthbar.fillAmount = health / maxHealth;
            if (health <= 0)
            {
                //die (reload level)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "badbreak")

        {
            healthbar.fillAmount = health / maxHealth;
            health--;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                //die (reload level)
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
        healthbar.fillAmount = health / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
    
