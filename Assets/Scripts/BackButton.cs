using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

    public string namaScene;

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Home")
            {
                Application.Quit();
                Debug.Log("QUIT !!");
            }
            else
            {
                SceneManager.LoadScene(namaScene);
            }
        }	
	}
}
