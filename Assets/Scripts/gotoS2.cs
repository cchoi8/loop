using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoS2 : MonoBehaviour
{

   // public GameObject enter;
    public string targetScene;

    // Start is called before the first frame update
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collision Detected");
            SceneManager.LoadScene(targetScene);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
