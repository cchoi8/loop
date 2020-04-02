using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectToilet : MonoBehaviour
{

    public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Score.theScore += 1;
    
        Destroy(gameObject);
    }


}
