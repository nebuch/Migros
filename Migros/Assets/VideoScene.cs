using UnityEngine;
using System.Collections;

public class VideoScene : MonoBehaviour
{
    public MediaPlayerCtrl mediaPlayer;
    public GameObject sphere;
    public PlayButton playButton;
    public Downloader downloader;
    public string videoName;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnEnable()
    {
        mediaPlayer.m_TargetMaterial[0] = sphere;

        mediaPlayer.m_strFileName = "file:///" +  downloader.downloader.downloadDirectory + "/" + videoName + ".mp4";
    }
}
