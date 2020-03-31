using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanges : MonoBehaviour
{
	//public String level;
	Scene scene;

	void Start()
	{
		scene = SceneManager.GetActiveScene();
		Debug.Log("Active Scene name is: " + scene.name + "\nActive Scene index: " + scene.buildIndex);
	}

	

	public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected");
        if (other.tag == "Player")
        {
			//SceneManager.LoadScene(level);
			SceneManager.LoadScene(" ", LoadSceneMode.Additive);
		}
    }
}

//To load a random scene from your game scene's index numbers (Build Settings):

//SceneManager.LoadScene(Random.Range(SCENE_NUM, SceneManager.sceneCount)); //change SCENE_NUM to the start number of your game scenes, assuming the rest of the scenes are game levels.