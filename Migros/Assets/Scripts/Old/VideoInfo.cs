using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VideoInfo : MonoBehaviour {
    public GameObject QAGameobjectToEnable;
    public GameObject QAGameobjectToDisable;
	[SerializeField] private VideoLoader _loader;
    public MediaPlayerCtrl _videoPlayer;
   
    void Start() {
        QAGameobjectToEnable.SetActive(false);
        QAGameobjectToDisable.SetActive(false);
    }
	
	void Update () {
       
            StartCoroutine(ActivateQA());
	}

    public IEnumerator ActivateQA() {
        
        if(_videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.PLAYING) {
            yield return new WaitForSeconds(GetVideoLengthInSeconds());
            _videoPlayer.Pause();
            QAGameobjectToEnable.SetActive(true);
            QAGameobjectToDisable.SetActive(false);
        }
        
    }

    private float GetVideoLengthInSeconds() {
        return _videoPlayer.GetDuration() / 1000;
    }
}
