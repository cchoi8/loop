using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_2 : MonoBehaviour
{

   // public GameObject enter;
   // public string targetScene;

    // Start is called before the first frame update
   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("V2");
        }
    }
}
