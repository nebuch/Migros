using UnityEngine;
using System.Collections;
//using UnityEditor;

public class VideoLoader : MonoBehaviour {
    
	[SerializeField] private MediaPlayerCtrl _videoPlayer;

	[Header ("Video Names")]

	public string _currentVideo;
	public string _nextVideo;
    public bool isPlaying = false;

    private string videoPath;

    // Use this for initialization
    void Start () {
        _videoPlayer = FindObjectOfType<MediaPlayerCtrl>();
        videoPath = "file://" + Application.persistentDataPath + "/";
        _currentVideo = PlayerPrefs.GetString("video"); 

        Debug.Log(_currentVideo);
	}
	
	public void LoadVideo(string currentVideo){
		_videoPlayer.Stop ();
		_videoPlayer.UnLoad ();
        _videoPlayer.m_strFileName = videoPath + currentVideo + ".mp4";
		_videoPlayer.Load (_videoPlayer.m_strFileName);
		_videoPlayer.Play ();
	
		Debug.Log ("new video loaded");
	}

    public string GetVideoPath() {
        return videoPath;
    }
}


