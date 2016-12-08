using UnityEngine;
using UnityEngine.UI;
using MonoLightTech.UnityUtil;

public class UserInput : Singleton<UserInput>
{
	public string CurrentInput { get; private set; }
	public int upLimit = 16;
	public int downLimit = 4;

	private Text _text;

	private void Start()
	{
		CurrentInput = string.Empty;
		_text = GetComponent<Text> ();
	}

	private void Update()
	{
		_text.text = string.IsNullOrEmpty(CurrentInput) ? "ID GIR" : CurrentInput;
	}

	public void AddLetter(char letter)
	{
		if (CurrentInput.Length >= upLimit)
			return;

		CurrentInput += letter;
	}

	public void Clear()
	{
		CurrentInput = string.Empty;
	}

	public void Enter()
	{
		if (CurrentInput.Length < downLimit) {
		
			Debug.Log("az karakter uyarisi");
			return;
		}


		PlayerPrefs.SetString ("userID", _text.text);
		Debug.Log (PlayerPrefs.GetString("userID"));
		Application.LoadLevel("MainMenu");
	}
}