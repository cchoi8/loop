using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door2SM : MonoBehaviour
{

    private Animator _animator;
    public AudioSource _audioS;
    //float timer;
  //  private AudioClip audio;


    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioS = GetComponent<AudioSource>();
        //Invoke(" ", 3.0f);
    }

    //    void OnEnable()
    //   {
    //    SceneManager.LoadScene("1theatre");
    //    audio.SetBool("open", true);
    //
    // }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("open sesami");
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
