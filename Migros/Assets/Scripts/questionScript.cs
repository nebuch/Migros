using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class questionScript : MonoBehaviour {

	[Header ("Game Objects")]
	public VideoLoader _videoLoader;
	public MediaPlayerCtrl _videoPlayer;
	public GameObject _questionContainer;
	public Text _questionText;
	public Text _answer1Text;
	public Text _answer2Text;
	public Text _answer3Text;
	public Text _answer4Text;
	public AnswerSystem _answer1System;
	public AnswerSystem _answer2System;
	public AnswerSystem _answer3System;
	public AnswerSystem _answer4System;
	[Header ("Strings")]
	public string _questionString;
	public string _answer1string;
	public string _answer2string;
	public string _answer3string;
	public string _answer4string;
	[Header("Videos")]
	public string _answer1video;
	public string _answer2video;
	public string _answer3video;
	public string _answer4video;
	[Header("Seek Events")]
	public int _answerCount;
	public int _questionSecond;
	private int _realSeconds;

	// Use this for initialization
	void Start () {

		if (_answerCount < 2) {
		
			_answerCount = 2;
		
		}
		_realSeconds = _questionSecond * 1000;
		Invoke ("QuestionAppears", _questionSecond);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void QuestionAppears(){
	
		Debug.Log ("question appears");
		_videoPlayer.Pause ();
		_questionText.text = _questionString;
		_answer1Text.text = _answer1string;
		_answer2Text.text = _answer2string;

		if (_answerCount == 3) {
			_answer3Text.text = _answer3string;
			_answer3System._toVideo = _answer3video;
		}

		if (_answerCount == 4) {
			_answer4System._toVideo = _answer4video;
			_answer4Text.text = _answer4string;
		}

		_answer1System._toVideo = _answer1video;
		_answer2System._toVideo = _answer2video;



		_questionContainer.SetActive (true);
	
	}

	public void QuestionDissappears(){
	
		_questionContainer.SetActive (false);
	
	}
}
