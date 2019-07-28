using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    AudioSource getSE;

    // Start is called before the first frame update
    void Start()
    {        getSE = GetComponent<AudioSource>();    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)    {        if (other.gameObject.CompareTag("Player"))        {                        getSE.Play();        }    }
    private void OnCollisionEnter(Collision collision)    {        if (collision.gameObject.CompareTag("Player"))        {            getSE.Play();        }    }
}
