using UnityEngine;
using System.Collections;
//using UnityEditor;

public class VideoLoader : MonoBehaviour {
    
	[SerializeField] private MediaPlayerCtrl _videoPlayer;

    private string videoPath;
    public string currentVideo;

    // Use this for initialization
    void Start () {
        _videoPlayer = FindObjectOfType<MediaPlayerCtrl>();
        videoPath = "file://" + Application.persistentDataPath + "/";
       // LoadVideo();
        
	}

    void Update() {
      //  LoadVideo();
    }

    private void OnEnable() {
       // LoadVideo();
    }



    public void LoadVideo(){
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


