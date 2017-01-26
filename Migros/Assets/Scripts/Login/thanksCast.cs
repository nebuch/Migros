using UnityEngine;
using System.Collections;

public class thanksCast : MonoBehaviour {

	public Transform _newUser;
	public Transform _newScenerio;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		RaycastHit hitted;
		if (Physics.Raycast (transform.position, transform.forward, out hitted, 1000)) {
			if (hitted.transform == _newUser) {

				Debug.Log ("newUser");
			}
			if (hitted.transform == _newScenerio) {

				Debug.Log ("newScenerio");
			}
		}
			}


	}

