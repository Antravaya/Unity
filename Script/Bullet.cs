using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private AudioSource _audioSource;

    void Start() 
    {
        _audioSource = GetComponent<AudioSource>();

        if(Input.GetButtonDown("Fire1"))
        {
            _audioSource.Play();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
