using UnityEngine;
using System.Collections;
//using UnityEditor;

public class VideoLoader : MonoBehaviour {
    
	public MediaPlayerCtrl _videoPlayer;

	[Header ("Video Names")]

	public string _currentVideo;
	public string _nextVideo;
    public bool isPlaying = false;

	// Use this for initialization
	void Start () {
	_currentVideo = PlayerPrefs.GetString("video"); 

        Debug.Log(_currentVideo);
	}
	
	// Update is called once per frame
	void Update () {
		_videoPlayer.m_strFileName = _currentVideo;

        

		/*if (Input.GetKeyUp (KeyCode.U)) {
		
			VideoLoad ();
		
		}*/

	}

	public void VideoLoad(){
		_videoPlayer.Stop ();
		_videoPlayer.UnLoad ();
        _currentVideo = _nextVideo;
		_videoPlayer.Load (_videoPlayer.m_strFileName);
		_videoPlayer.Play ();
	
		Debug.Log ("new video loaded");
	}

    public IEnumerator PlayVideo() {
        yield return null;
        isPlaying = true;
        _videoPlayer.Play();
        
    }
}


