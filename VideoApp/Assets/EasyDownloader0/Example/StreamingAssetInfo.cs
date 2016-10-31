using UnityEngine;
using System.Collections;
using System.IO;

public class StreamingAssetInfo : MonoBehaviour {

    public string videoFile;

    

	// Use this for initialization
	void Start () {
        var info = new DirectoryInfo("D:/Projects/Unity Projects/PulseVR/VideoApp/Assets/StreamingAssets");

        var fileInfo = info.GetFiles();
        
        foreach(var file in fileInfo)
        {
            if (file.Extension == ".ogg")
                videoFile = file.Name;
            Debug.Log(videoFile);
        }
           
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
