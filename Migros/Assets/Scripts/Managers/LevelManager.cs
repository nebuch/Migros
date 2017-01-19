using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System;

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

    public bool block = false;

    void Start () {
	    v_data = FindObjectOfType<VideoData>();
        q_data = FindObjectOfType<QuestionData>();
        a_data = FindObjectOfType<AnswerData>();
        b_data = FindObjectOfType<BooleanData>();
       // videoPlayer = FindObjectOfType<MediaPlayerCtrl>();
        videoLoader = FindObjectOfType<VideoLoader>(); 
        _QAManager = GameObject.FindObjectOfType<QAManager>();

        videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
    }

    void Update() {
        
    }

    private void OnEnable() {
        videoPlayer.OnEnd += PlayVideo;
    }

    private void OnDisable() {
        videoPlayer.OnEnd -= PlayVideo;
    }

    void PlayVideo() {
        
        Sequence_1();
        
    }

    void Sequence_1() {
        if (!b_data.createAnswer && !block) {
            videoLoader.LoadVideo(v_data.nextVideo0);
            SceneManager.LoadScene("LoginScreen");
            Debug.Log("Next scene");
            block = true;
        }

        if (block && b_data.createAnswer) {
            _QAManager.ShowQuestionAnswer(q_data.question0, a_data.answer1, a_data.answer2, a_data.answer3, a_data.answer4, a_data.numberOfAnswers);

            foreach (GameObject answer in answerSystem) {
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1) {
                    Debug.Log("Answer1");
                }
            }
        }
        































            /*else {
                
                _QAManager.ShowQuestionAnswer(q_data.question0, a_data.answer1, a_data.answer2, a_data.answer3, a_data.answer4, a_data.numberOfAnswers);
                foreach (GameObject answer in answerSystem) {
                    if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1) {
                        Debug.Log("answer1");
                        videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video1 + ".mp4";
                        videoLoader.LoadVideo();
                        _QAManager.HideQuestionAnswer();
                       // Answer1Video();
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer2") {
                        Debug.Log("answer2");
                      //  videoLoader.LoadVideo(v_data.video2);
                        _QAManager.HideQuestionAnswer();
                        Answer2Video();
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer3")
                    {
                      //  videoLoader.LoadVideo(v_data.video3);
                        _QAManager.HideQuestionAnswer();
                        Answer3Video();
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer4")
                    {
                       // videoLoader.LoadVideo(v_data.video4);
                        _QAManager.HideQuestionAnswer();
                        Answer4Video();
                    }
                }  
            }*/
        
    }

    private void Answer1Video()
    {
        if (videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            
            if (!b_data.createAnswer1)
            {
                //videoPlayer.m_strFileName = videoPath + v_data.nextVideo0 + ".mp4";
                currentVideo = v_data.nextVideo1;
               // videoLoader.LoadVideo(currentVideo);
            }
            else
            {
                _QAManager.ShowQuestionAnswer(q_data.question1, a_data.answer1_1, a_data.answer1_2, a_data.answer1_3, a_data.answer1_4, a_data.numberOfAnswers1);
                foreach (GameObject answer in answerSystem)
                {
                    if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1_1)
                    {
                        Debug.Log("answer1-1");
                       // videoLoader.LoadVideo(v_data.video1_1);
                        _QAManager.HideQuestionAnswer();
                       
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer2")
                    {
                        Debug.Log("answer1-2");
                       // videoLoader.LoadVideo(v_data.video1_2);
                        _QAManager.HideQuestionAnswer();
                       
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer3")
                    {
                       // videoLoader.LoadVideo(v_data.video1_3);
                        _QAManager.HideQuestionAnswer();
                       
                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer4")
                    {
                       // videoLoader.LoadVideo(v_data.video1_4);
                        
                        _QAManager.HideQuestionAnswer();
                      
                    }
                }
            }
        }
    }

    private void Answer2Video()
    {
        if (videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            if (!b_data.createAnswer2)
            {
                //videoPlayer.m_strFileName = videoPath + v_data.nextVideo0 + ".mp4";
                currentVideo = v_data.nextVideo2;
               // videoLoader.LoadVideo(currentVideo);
                
            }
            else
            {
                _QAManager.ShowQuestionAnswer(q_data.question2, a_data.answer2_1, a_data.answer2_2, a_data.answer2_3, a_data.answer2_4, a_data.numberOfAnswers2);
                foreach (GameObject answer in answerSystem)
                {
                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer1")
                    {
                        Debug.Log("answer2-1");
                       // videoLoader.LoadVideo(v_data.video2_1);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer2")
                    {
                        Debug.Log("answer2-2");
                      // videoLoader.LoadVideo(v_data.video2_2);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer3")
                    {
                      // videoLoader.LoadVideo(v_data.video2_3);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer4")
                    {
                      //  videoLoader.LoadVideo(v_data.video2_4);
                        _QAManager.HideQuestionAnswer();

                    }
                }
            }
        }
    }

    private void Answer3Video()
    {
        if (videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            if (!b_data.createAnswer3)
            {
                //videoPlayer.m_strFileName = videoPath + v_data.nextVideo0 + ".mp4";
                currentVideo = v_data.nextVideo3;
               // videoLoader.LoadVideo(currentVideo);
            }
            else
            {
                _QAManager.ShowQuestionAnswer(q_data.question3, a_data.answer3_1, a_data.answer3_2, a_data.answer3_3, a_data.answer3_4, a_data.numberOfAnswers3);
                foreach (GameObject answer in answerSystem)
                {
                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer1")
                    {
                        Debug.Log("answer3-1");
                       // videoLoader.LoadVideo(v_data.video3_1);                        
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer2")
                    {
                        Debug.Log("answer3-2");
                      // videoLoader.LoadVideo(v_data.video3_2);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer3")
                    {
                       // videoLoader.LoadVideo(v_data.video3_3);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer4")
                    {
                       // videoLoader.LoadVideo(v_data.video3_4);
                        _QAManager.HideQuestionAnswer();

                    }
                }
            }
        }
    }

    private void Answer4Video()
    {
        if (videoPlayer.GetCurrentState() == MediaPlayerCtrl.MEDIAPLAYER_STATE.END)
        {
            if (!b_data.createAnswer4)
            {
                //videoPlayer.m_strFileName = videoPath + v_data.nextVideo0 + ".mp4";
                currentVideo = v_data.nextVideo4;
              // videoLoader.LoadVideo(currentVideo);
            }
            else
            {
                _QAManager.ShowQuestionAnswer(q_data.question4, a_data.answer4_1, a_data.answer4_2, a_data.answer4_3, a_data.answer4_4, a_data.numberOfAnswers4);
                foreach (GameObject answer in answerSystem)
                {
                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer1")
                    {
                        Debug.Log("answer4-1");
                        //videoLoader.LoadVideo(v_data.video4_1);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer2")
                    {
                        Debug.Log("answer4-2");
                       //videoLoader.LoadVideo(v_data.video4_2);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer3")
                    {
                        //videoLoader.LoadVideo(v_data.video4_3);
                        _QAManager.HideQuestionAnswer();

                    }

                    if (answer.GetComponent<AnswerSystem>().answerGiven == "Answer4")
                    {
                       //videoLoader.LoadVideo(v_data.video4_4);
                        _QAManager.HideQuestionAnswer();

                    }
                }
            }
        }
    }
}
