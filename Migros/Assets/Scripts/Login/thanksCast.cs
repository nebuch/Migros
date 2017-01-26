using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;

public class thanksCast : MonoBehaviour {

	public Transform _newUser;
	public Transform _newScenerio;
	public VRCameraFade _cameraFade;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		RaycastHit hitted;
		if (Physics.Raycast (transform.position, transform.forward, out hitted, 1000)) {
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				if (hitted.transform == _newUser) {

					Debug.Log ("newUser");
					StartCoroutine(_cameraFade.BeginFadeOut(true));
				}
				if (hitted.transform == _newScenerio) {

					Debug.Log ("newScenerio");
					StartCoroutine(_cameraFade.BeginFadeOut(true));
				}
			}
		}
			}


	}

