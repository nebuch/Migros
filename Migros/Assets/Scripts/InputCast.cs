using UnityEngine;
using System.Collections;
using MonoLightTech.UnityUtil;

public class InputCast : Singleton<InputCast>
{
	public delegate void ResetKeyMat();

	public event ResetKeyMat ResetEvent;

	private void OnGUI()
	{
		//GUI.Box (new Rect((Screen.width / 2) - 5, (Screen.height / 2) - 5, 10, 10), string.Empty);
	}

	private void Update()
	{
		if (ResetEvent != null)
			ResetEvent ();

		RaycastHit hit;
		if (Physics.Raycast (transform.position, transform.forward, out hit, 1000)) {
			if (Input.GetKeyDown (KeyCode.Mouse0)) {
				KeyId keyId = hit.transform.gameObject.GetComponent<KeyId> ();
				if (keyId != null) {
					keyId.Action ();
				}
			}

			KeyMat keyMat = hit.transform.gameObject.GetComponent<KeyMat> ();
			if (keyMat != null) {
				keyMat.status = true;
			}
		}
	}
}