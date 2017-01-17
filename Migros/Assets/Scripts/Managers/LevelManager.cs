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
    [SerializeField] private VideoLoader videoLoader;
    [SerializeField] private GameObject[] answerSystem;
    [SerializeField] private string currentVideo;
    [SerializeField] private string answerToVideo;

    void Start () {
	    v_data = FindObjectOfType<VideoData>();
        q_data = FindObjectOfType<QuestionData>();
        a_data = FindObjectOfType<AnswerData>();
        b_data = FindObjectOfType<BooleanData>();
        videoPlayer = FindObjectOfType<MediaPlayerCtrl>();
        videoLoader = FindObjectOfType<VideoLoader>();
        
        _QAManager = GameObject.FindObjectOfType<QAManager>();
       
       // answerToVideo = 
        
    }
	
	void Update () {
	    //StartCoroutine(Sequence_1());
        Sequence_1();
    }

    void Sequence_1() {
        videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.entryVideo + ".mp4";
        if(videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END) {
            if (b_data.noQuestion0) {
                //videoPlayer.m_strFileName = videoPath + v_data.nextVideo0 + ".mp4";
                currentVideo = v_data.nextVideo0;
                videoLoader.LoadVideo(currentVideo);
            }
            else {
                _QAManager.ShowQuestionAnswer(q_data.question0, a_data.answer1, a_data.answer2, a_data.answer3, a_data.answer4, a_data.numberOfAnswers);
                foreach (GameObject answer in answerSystem) {
                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer1") {
                        videoLoader.LoadVideo(v_data.video1);
                        
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer2") {
                        videoLoader.LoadVideo(v_data.video2);
                    }
                     
                    _QAManager.HideQuestionAnswer();      
                }
            }
        }
    }

    
}
