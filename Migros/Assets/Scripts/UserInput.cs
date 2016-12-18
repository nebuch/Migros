using UnityEngine;
using UnityEngine.UI;
using MonoLightTech.UnityUtil;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;

public class UserInput : Singleton<UserInput>
{
	public string CurrentInput { get; private set; }
	public int upLimit = 16;
	public int downLimit = 4;
	public VRCameraFade _cameraFade;
	private Text _text;
	private bool _userIDReady;

	private void Start()
	{
		CurrentInput = string.Empty;
		_text = GetComponent<Text> ();
		//_cameraFade.OnFadeComplete += FadeComplete ();
	}

	private void Update()
	{
		_text.text = string.IsNullOrEmpty(CurrentInput) ? "ID GIR" : CurrentInput;

		if (_userIDReady && _cameraFade._fadeComplete) {

			SceneManager.LoadScene("MainMenu");

		}
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

		StartCoroutine(_cameraFade.BeginFadeOut(true));
		_userIDReady = true;
		PlayerPrefs.SetString ("userID", _text.text);
		Debug.Log (PlayerPrefs.GetString("userID"));

	}



	


}