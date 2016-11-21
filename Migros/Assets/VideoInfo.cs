using UnityEngine;
using System.Collections;

public class VideoInfo : MonoBehaviour {
    public GameObject QAGameobjectToEnable;
	[SerializeField] private VideoLoader _loader;
   
    void Start() {
        QAGameobjectToEnable.SetActive(false);
    }
	
	void Update () {
       
            StartCoroutine(ActivateQA());
	}

    public IEnumerator ActivateQA() {
        yield return StartCoroutine(_loader.PlayVideo()); //It plays the video but somehow it does not wait till the end of the video 
        StopAllCoroutines();
        QAGameobjectToEnable.SetActive(true);
    }
}
