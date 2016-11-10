using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;

public class Downloader : MonoBehaviour {

    public bool downloadFinished;

    public string url;
    public float progressValue;
    public GameObject playButton, downloadButton;
    public UploadAndDownload downloader;
    public GameObject progressBar;
    public string _downloadDir;

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
        downloader.downloadDirectory = Application.persistentDataPath + _downloadDir;

        Debug.Log("Download directory: " + downloader.downloadDirectory);

    }

    void Update()
    {
        if (Directory.Exists(downloader.downloadDirectory))
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
        progressBar.SetActive(false);
        playButton.SetActive(true);
        downloadButton.SetActive(false);
        progressBar.SetActive(false);

        Debug.Log("Downloaded to: " + downloader.downloadDirectory);

    }

    void OnSavedToDisk(string path)
    {
      
    }


}
