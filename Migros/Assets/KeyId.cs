using UnityEngine;

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

	public void Action()
	{
		switch (action) {
		default:
		case KeyAction.Letter:
			SendToInput ();
			break;
		case KeyAction.Enter:
			Enter ();
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

	private void Enter()
	{
		UserInput.Instance.Enter ();
	}

	private void Clear()
	{
		UserInput.Instance.Clear ();
	}
}