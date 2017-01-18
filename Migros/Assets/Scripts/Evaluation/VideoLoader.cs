using UnityEngine;
using System.Collections;
//using UnityEditor;

public class VideoLoader : MonoBehaviour {
    
	[SerializeField] private MediaPlayerCtrl _videoPlayer;

    private string videoPath;

    // Use this for initialization
    void Start () {
        _videoPlayer = FindObjectOfType<MediaPlayerCtrl>();
        videoPath = "file://" + Application.persistentDataPath + "/";


	}
	
	public IEnumerator LoadVideo(string currentVideo){
		_videoPlayer.Stop ();
		_videoPlayer.UnLoad ();
        _videoPlayer.m_strFileName = videoPath + currentVideo + ".mp4";
		_videoPlayer.Load (_videoPlayer.m_strFileName);
		_videoPlayer.Play ();
        yield return new WaitForSeconds(_videoPlayer.GetDuration() / 1000);
        //_videoPlayer.Stop();
        
		//Debug.Log ("new video loaded");
	}

    public string GetVideoPath() {
        return videoPath;
    }
}


