using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private Animator _animator;
    private AudioSource audioS;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")

        _animator.SetBool("open", true);
  //      Aks
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
