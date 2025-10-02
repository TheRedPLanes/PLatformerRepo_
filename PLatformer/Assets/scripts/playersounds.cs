using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playersounds : MonoBehaviour
{
    private AudioSource AudioSource;
    public AudioClip movementSound;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        if (AudioSource == null)
        {
            Debug.LogError("AudioSource component not found on this");
        }
        if (movementSound != null)
        {
            AudioSource.clip = movementSound;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            if (!AudioSource.isPlaying)
            {
                AudioSource.Play();
            }
        }
        else
        {
            if (!AudioSource.isPlaying)
            {
                AudioSource.Stop();
            }
        }
    }
}
