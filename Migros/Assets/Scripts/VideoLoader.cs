using UnityEngine;
using System.Collections;
//using UnityEditor;



public class VideoLoader : MonoBehaviour {



	public MediaPlayerCtrl _videoPlayer;

	[Header ("Video Names")]

	public string _currentVideo;
	public string _nextVideo;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_currentVideo = _videoPlayer.m_strFileName;

		if (Input.GetKeyUp (KeyCode.U)) {
		
			VideoLoad ();
		
		}

		if (Input.GetKeyUp (KeyCode.P)) {

			VideoPause ();

		}

	}

	public void VideoLoad(){
		_videoPlayer.Stop ();
		_videoPlayer.UnLoad ();

		_videoPlayer.Load (_nextVideo);
		_videoPlayer.Play ();
	
		Debug.Log ("new video loaded");
	}

	public void VideoPause(){
	
		Debug.Log (_videoPlayer.GetSeekPosition ());
		_videoPlayer.Pause ();
	
	}

}


