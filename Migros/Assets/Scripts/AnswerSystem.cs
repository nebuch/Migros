using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class AnswerSystem : MonoBehaviour {
	public VideoLoader _videoLoader;

	public GameObject _toVideo;
    public GameObject videoToDisable;

	[Header ("Answer Attr.")]
	public int _questionID;
	public int _answerID;
	private int _packID;
	private int _userID;

	[Header ("Player")]

	public Collider _targeter;
	public Button _button;
	public GameObject _eventSystem;
	private bool _selected;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(_selected&&Input.GetButtonDown("Fire1")){

			_button.onClick.Invoke ();
			Debug.Log (this.gameObject.name + "was clicked");
		}
	}

	public void ThisAnswerGiven(){
	
		//_videoLoader._nextVideo = _toVideo;
		//_videoLoader.VideoLoad ();

        _toVideo.SetActive(true);
        videoToDisable.SetActive(false);
	    _videoLoader._nextVideo ="file:///" + Application.persistentDataPath + "/" + _toVideo.GetComponent<PlayButton>().videoName + ".mp4";
        _videoLoader.VideoLoad();
        PlayerPrefs.SetString (string.Format ("{0}: {1:0}_ {2:0}: {3:0}_ {4:0}: {5:0}_ {6:0}: {7:0}", "user", _userID, "pack", _packID, "question", _questionID, "answer", _answerID), "Answer Given");

		Debug.Log (string.Format ("{0}: {1:0}_ {2:0}: {3:0}_ {4:0}: {5:0}_ {6:0}: {7:0}", "user", _userID, "pack", _packID, "question", _questionID, "answer", _answerID));
	}

	void OnTriggerEnter(Collider other){
	
	

		if (other == _targeter) {
		
			_button.Select ();
			_selected = true;
		}
	
	}



	void OnTriggerExit(Collider other2){

		if (other2 == _targeter) {

			_eventSystem.GetComponent<EventSystem> ().SetSelectedGameObject (null);
			_selected = false;
		}

	}





}
