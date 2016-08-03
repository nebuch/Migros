using UnityEngine;
using System.IO;
using System.Collections;

public class Downloader : MonoBehaviour {

    public bool downloadFinished;

    public string url;
    public float progressValue;
    public GameObject playButton, downloadButton;
    public UploadAndDownload downloader;
    public GameObject progressBar;
    public string[] _downloadDir;

    



    void OnEnable()
    {
        if (downloader == null)
            Debug.LogWarning("Downloader not initialised!");
        else
        {
            UploadAndDownload.onDownloadComplete += OnDownloadComplete;
            UploadAndDownload.onError += OnError;
            UploadAndDownload.onProgress += OnProgress;
            UploadAndDownload.onSaved += OnSavedToDisk;
        }
    }

    void OnDisable()
    {
        UploadAndDownload.onDownloadComplete -= OnDownloadComplete;
        UploadAndDownload.onError -= OnError;
        UploadAndDownload.onProgress -= OnProgress;
        UploadAndDownload.onSaved -= OnSavedToDisk;
    }

    
    // Use this for initialization
    void Start () {

        //downloader.downloadDirectory = Application.persistentDataPath;
        //downloader.downloadDirectory = "D:/Projects/Unity Projects/PulseVR/VideoApp/Assets/StreamingAssets";
        downloader.downloadDirectory = _downloadDir[0];
       
        

    }

    void Update()
    {
        if (Directory.GetFiles(_downloadDir[0]).Length != 0 )
        {
            downloadButton.SetActive(false);
            playButton.SetActive(true);
            
        }
        else
        {
            downloadButton.SetActive(true);
            playButton.SetActive(false);
            downloadFinished = false;
        }

        if(downloadFinished)
        {
            progressBar.SetActive(false);
        }
        
    }

    public void DownloadFromUrl()
    {
        downloader.Download(url, true, false);
        progressBar.SetActive(true);
      
    }

    void OnError(string error)
    {
        Debug.Log("Error in downloading, Error : " + error);
    }

    void OnProgress(float progress)
    {
        progressValue = progress * 100;
       
    }


    void OnDownloadComplete(UploadAndDownload.Data data)
    {
        downloadFinished = true;
    }

    void OnSavedToDisk(string path)
    {
        //Debug.Log("Data saved at path : " + path);
    }


}
