using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioClip sound1;
    public AudioClip sound2;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {        audioSource = GetComponent<AudioSource>();    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)    {        audioSource.PlayOneShot(sound1);    }

    private void OnCollisionEnter2D(Collision2D collision)    {        audioSource.PlayOneShot(sound2);    }
}
