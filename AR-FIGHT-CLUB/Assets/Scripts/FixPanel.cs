using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class FixPanel : MonoBehaviour {

	public GameObject CameraButton;

	private string CurrentScene;


	void Start() {
		CurrentScene = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {
		if (DefaultTrackableEventHandler.TrueFals == true) {
			CameraButton.SetActive (false);
		}
	}

	public void Refresh() {
		SceneManager.LoadScene (CurrentScene);
		
	}



}
