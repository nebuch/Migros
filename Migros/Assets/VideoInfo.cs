using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VideoInfo : MonoBehaviour {
    public GameObject QAGameobjectToEnable;
    public GameObject QAGameobjectToDisable;
	[SerializeField] private VideoLoader _loader;
   
    void Start() {
        QAGameobjectToEnable.SetActive(false);
    }
	
	void Update () {
       
            StartCoroutine(ActivateQA());
	}

    public IEnumerator ActivateQA() {
        StartCoroutine(_loader.PlayVideo()); //It plays the video but somehow it does not wait till the end of the video 
        yield return null;
        StopAllCoroutines();
        QAGameobjectToEnable.SetActive(true);
        QAGameobjectToDisable.SetActive(false);
    }
}
