﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    public AudioClip pointUpSE;
    public AudioClip damageSE;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {        audioSource = GetComponent<AudioSource>();    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)    {        audioSource.PlayOneShot(pointUpSE);    }

    private void OnCollisionEnter2D(Collision2D collision)    {        if (collision.gameObject.CompareTag("Bomb"))        {            audioSource.PlayOneShot(damageSE);        }    }
}
