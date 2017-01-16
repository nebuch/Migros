using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour 
{
    [SerializeField] private VideoData v_data;
    [SerializeField] private QuestionData q_data;
    [SerializeField] private AnswerData a_data;
    [SerializeField] private BooleanData b_data;
    [SerializeField] private QAManager _QAManager;
    [SerializeField] private MediaPlayerCtrl videoPlayer;
    [SerializeField] private string videoPath;
    [SerializeField] private string currentVideo;

    void Start () {
	    v_data = FindObjectOfType<VideoData>();
        q_data = FindObjectOfType<QuestionData>();
        a_data = FindObjectOfType<AnswerData>();
        b_data = FindObjectOfType<BooleanData>();
        videoPlayer = FindObjectOfType<MediaPlayerCtrl>();
        _QAManager = GameObject.FindObjectOfType<QAManager>();
        videoPath = "file://" + Application.persistentDataPath + "/";
    }
	
	void Update () {
	    //StartCoroutine(Sequence_1());
        Sequence_1();
	}

    void Sequence_1() {
        videoPlayer.m_strFileName = videoPath + v_data.entryVideo + ".mp4";
        if(videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END) {
            if (b_data.noQuestion0) {
                //videoPlayer.m_strFileName = videoPath + v_data.nextVideo0 + ".mp4";
                currentVideo = v_data.nextVideo0;
                LoadVideo(currentVideo);
            }
            else {
                _QAManager.ShowQuestionAnswer(q_data.question0, a_data.answer1, a_data.answer2, a_data.answer3, a_data.answer4, a_data.numberOfAnswers);
            }
        }
        


    }

    







    void LoadVideo(string currentVideo) {
        videoPlayer.Stop();
        videoPlayer.UnLoad();
        videoPlayer.m_strFileName = videoPath + currentVideo + ".mp4";
        videoPlayer.Load(videoPlayer.m_strFileName);
        videoPlayer.Play();
    }
}
