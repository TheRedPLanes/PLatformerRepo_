using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class loadnext : MonoBehaviour
{
    //store level name
    public string LevelToLoad;
    //when player collides with me -- i am the flag, load given level.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(LevelToLoad);
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
