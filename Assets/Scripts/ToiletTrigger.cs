using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletTrigger : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("help me");

    }
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void OnTriggerEnger(Collider col)
    {
        if (col.gameObject.tag == ("ToiletTrigger"))
            anim.enabled = true;
    }
}

