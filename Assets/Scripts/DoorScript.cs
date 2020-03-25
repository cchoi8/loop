using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private Animator _animator;
    public AudioSource _audioS;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioS = GetComponent<AudioSource>();
        Invoke(" ", 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

        _animator.SetBool("open", true);

       
       _audioS.Play();


    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("close sesami");
        if (other.tag == "Player")

            _animator.SetBool("open", false);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
