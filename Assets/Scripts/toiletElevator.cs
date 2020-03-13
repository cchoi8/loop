using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toiletElevator : MonoBehaviour
{
    
	private Animator _animator;

    
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
       
    }

    
    private void OnTriggerEnter(Collider other)
    {Debug.Log("help me");
        if (other.tag == "Player")

            
            _animator.SetBool("open", true);
    }
}

