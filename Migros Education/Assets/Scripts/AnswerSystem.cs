using UnityEngine;
using System.Collections;

public class AnswerSystem : MonoBehaviour {
	public VideoLoader _videoLoader;

	public string _toVideo;

	[Header ("Answer Attr.")]
	public int _questionID;
	public int _answerID;
	private int _packID;
	private int _userID;


	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ThisAnswerGiven(){
	
		_videoLoader._nextVideo = _toVideo;
		_videoLoader.VideoLoad ();
	
		PlayerPrefs.SetString (string.Format ("{0}: {1:0}_ {2:0}: {3:0}_ {4:0}: {5:0}_ {6:0}: {7:0}", "user", _userID, "pack", _packID, "question", _questionID, "answer", _answerID), "Answer Given");

		Debug.Log (string.Format ("{0}: {1:0}_ {2:0}: {3:0}_ {4:0}: {5:0}_ {6:0}: {7:0}", "user", _userID, "pack", _packID, "question", _questionID, "answer", _answerID));
	}

}
