using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectToilet : MonoBehaviour
{

    public AudioSource collectSound;
    public int value;
    public float rotateSpeed;


    void Update()
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }

        void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Score.theScore += 100;
    
        Destroy(gameObject);
    }


}
