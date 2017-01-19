using UnityEngine;
using System.Collections;
using LitJson;

public class VideoData : MonoBehaviour 
{
    private JsonData data;
    [SerializeField] private ReadJson videoData;
    [SerializeField] public string nextVideo0, nextVideo1, nextVideo2, nextVideo3, nextVideo4;
    [SerializeField] public string video0, video1, video2, video3, video4;
    [SerializeField] public string video1_1, video1_2, video1_3, video1_4;
    [SerializeField] public string video2_1, video2_2, video2_3, video2_4;
    [SerializeField] public string video3_1, video3_2, video3_3, video3_4;
    [SerializeField] public string video4_1, video4_2, video4_3, video4_4;

    void Awake() {
        videoData = FindObjectOfType<ReadJson>();
    }

	void Start () {
	    data = videoData.GetData();
        InitializeVideoData();    
	}
	
    private void InitializeVideoData() {
        
        video0 = data["video0"].ToString();
        video1 = data["video1"].ToString();
        video2 = data["video2"].ToString();
        video3 = data["video3"].ToString();
        video4 = data["video4"].ToString();

        video1_1 = data["video1-1"].ToString();
        video1_2 = data["video1-2"].ToString();
        video1_3 = data["video1-3"].ToString();
        video1_4 = data["video1-4"].ToString();

        video2_1 = data["video2-1"].ToString();
        video2_2 = data["video2-2"].ToString();
        video2_3 = data["video2-3"].ToString();
        video2_4 = data["video2-4"].ToString();

        video3_1 = data["video3-1"].ToString();
        video3_2 = data["video3-2"].ToString();
        video3_3 = data["video3-3"].ToString();
        video3_4 = data["video3-4"].ToString();

        video4_1 = data["video4-1"].ToString();
        video4_2 = data["video4-2"].ToString();
        video4_3 = data["video4-3"].ToString();
        video4_4 = data["video4-4"].ToString();

        nextVideo0 = data["nextVideo0"].ToString();
        nextVideo1 = data["nextVideo1"].ToString();
        nextVideo2 = data["nextVideo2"].ToString();
        nextVideo3 = data["nextVideo3"].ToString();
        nextVideo4 = data["nextVideo4"].ToString();
    }
}
