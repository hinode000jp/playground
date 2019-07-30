using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointUp : MonoBehaviour
{
    AudioSource getPointSE;

    void Start()
    {
        getPointSE = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision1)    {        Debug.Log("Collision");    }


    private void OnTriggerEnter2D(Collider2D collision)    {        Debug.Log("Point");        if (collision.gameObject.CompareTag("Point"))        {            getPointSE.Play();        }    }
}
