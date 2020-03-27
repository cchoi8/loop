using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_3 : MonoBehaviour
{
    //private Animator _animator;
    // public GameObject enter;
    // public string targetScene;

    // Start is called before the first frame update
    void OnEnable()
    {
		SceneManager.LoadScene("VVV");

	}

   // private void OnTriggerEnter(Collider other)
   // {
     //   Debug.Log("Collision Detected");
      //  if (other.tag == "Player")
     //   {
           // _animator.SetBool("open", true);

      //        SceneManager.LoadScene("supper");
      //  }
    //}
}
