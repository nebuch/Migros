using System.Collections;
using UnityEngine;
using VRStandardAssets.Utils;

public enum KeyAction
{
	Letter = 0,
	Enter,
	Clear
}

public class KeyId : MonoBehaviour
{
	public char key;
	public KeyAction action;
    public VRCameraFade _cameraFade;

	public void Action()
	{
		switch (action) {
		default:
		case KeyAction.Letter:
			SendToInput ();
			break;
		case KeyAction.Enter:
			StartCoroutine(Enter());
			break;
		case KeyAction.Clear:
			Clear ();
			break;
		}
	}

	private void SendToInput()
	{
		UserInput.Instance.AddLetter (key);
	}

	private IEnumerator Enter()
	{
        yield return StartCoroutine(_cameraFade.BeginFadeOut(true));
		UserInput.Instance.Enter ();
	}

	private void Clear()
	{
		UserInput.Instance.Clear ();
	}
}