﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_2 : MonoBehaviour
{
   private const string SceneName = "VVV";

    // public GameObject enter;
    // public string targetScene;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");
        if (other.tag == "Player")
            SceneManager.LoadScene("VVV");
    }
}
