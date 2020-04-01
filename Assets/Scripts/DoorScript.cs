using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private Animator _animator;
    public AudioSource _audioS;
    public AudioClip _audioSS;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioS = GetComponent<AudioSource>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

        _animator.SetBool("open", true);

        _audioS.PlayOneShot(_audioSS, 10f);
        //or if you just want to play without sec delay
        //_audioS.Play();


    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("close sesami");
        if (other.tag == "Player")

            _animator.SetBool("open", false);
            _audioS.Stop();
    }
}

