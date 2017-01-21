using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using VRStandardAssets.Utils;

public class LevelManager : MonoBehaviour 
{
    [SerializeField] private VideoData v_data;
    [SerializeField] private QuestionData q_data;
    [SerializeField] private AnswerData a_data;
    [SerializeField] private BooleanData b_data;
    [SerializeField] private QAManager _QAManager;
    [SerializeField] private MediaPlayerCtrl videoPlayer;
    [SerializeField] private VRCameraFade cameraFade;
    [SerializeField] private VideoLoader videoLoader;
    [SerializeField] private GameObject[] answerSystem;
    
    public string sceneName;
    public string path;
    public bool endVideo;

    void Start () { 
        sceneName = SceneManager.GetActiveScene().name;
        path = PlayerPrefs.GetString("path");
    }

    void Update() {
       PlayFirstVideo();
    }

    private void OnEnable() {
        videoPlayer.OnEnd += CheckVideoEnd;
    }

    private void OnDisable() {
        videoPlayer.OnEnd -= CheckVideoEnd;
    }

    void PlayFirstVideo() {
        switch (sceneName) {
            case "Slaughterhouse":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
                Sequence_0();
                break;
            case "Hygene":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
                Sequence_0();
                break;
            case "Logistics":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
                Sequence_0();
                break;
            case "Grocery":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
                Sequence_0();
                break;
            case "Checkout":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
                Sequence_0();
                break;
            case "Bakery":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video0 + ".mp4";
                Sequence_0();
                break;

            case "Video1":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video1 + ".mp4";
                Sequence_1();
                break;
            case "Video2":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video2 + ".mp4";
                Sequence_2();
                break;
            case "Video3":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video3 + ".mp4";
                Sequence_3();
                break;
            case "Video4":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video4 + ".mp4";
                Sequence_4();
                break;
            case "Video1-1":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video1_1 + ".mp4";
                break;
            case "Video1-2":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video1_2 + ".mp4";
                break;
            case "Video1-3":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video1_3 + ".mp4";
                break;
            case "Video1-4":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video1_4 + ".mp4";
                break;
            case "Video2-1":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video2_1 + ".mp4";
                break;
            case "Video2-2":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video2_2 + ".mp4";
                break;
            case "Video2-3":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video2_3 + ".mp4";
                break;
            case "Video2-4":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video2_4 + ".mp4";
                break;
            case "Video3-1":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video3_1 + ".mp4";
                break;
            case "Video3-2":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video3_2 + ".mp4";
                break;
            case "Video3-3":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video3_3 + ".mp4";
                break;
            case "Video3-4":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video3_4 + ".mp4";
                break;
            case "Video4-1":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video4_1 + ".mp4";
                break;
            case "Video4-2":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video4_2 + ".mp4";
                break;
            case "Video4-3":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video4_3 + ".mp4";
                break;
            case "Video4-4":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.video4_4 + ".mp4";
                break;
            case "NextVideo0":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.nextVideo0 + ".mp4";
                break;
            case "NextVideo1":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.nextVideo1 + ".mp4";
                break;
            case "NextVideo2":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.nextVideo2 + ".mp4";
                break;
            case "NextVideo3":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.nextVideo3 + ".mp4";
                break;
            case "NextVideo4":
                videoPlayer.m_strFileName = videoLoader.GetVideoPath() + v_data.nextVideo4 + ".mp4";
                break;
        }
    }

    void CheckVideoEnd() {
        endVideo = true;     
    }

    
    void Sequence_0() {
        if (!b_data.createAnswer) {
            SceneManager.LoadScene("NextVideo0");
        }

        if (b_data.createAnswer && endVideo) {
            _QAManager.ShowQuestionAnswer(q_data.question0, a_data.answer1, a_data.answer2, a_data.answer3, a_data.answer4, a_data.numberOfAnswers);

            foreach (GameObject answer in answerSystem) {
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1) {
                    SceneManager.LoadScene("Video1");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer2) {
                    SceneManager.LoadScene("Video2");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer3) {
                    SceneManager.LoadScene("Video3");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer4) {
                    SceneManager.LoadScene("Video4");
                }
            }
        }
    }

    void Sequence_1() {
        if (!b_data.createAnswer1 && endVideo) {
            SceneManager.LoadScene("NextVideo1");
        }

        if (b_data.createAnswer1 && endVideo) {
            _QAManager.ShowQuestionAnswer(q_data.question1, a_data.answer1_1, a_data.answer1_2, a_data.answer1_3, a_data.answer1_4, a_data.numberOfAnswers1);

            foreach (GameObject answer in answerSystem) {
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1_1) {
                    SceneManager.LoadScene("Video1-1");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1_2) {
                    SceneManager.LoadScene("Video1-2");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1_3) {
                    SceneManager.LoadScene("Video1-3");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer1_4) {
                    SceneManager.LoadScene("Video1-4");
                }
            }
        }
    }

    void Sequence_2() {
        if (!b_data.createAnswer2 && endVideo) {
            SceneManager.LoadScene("NextVideo2");
        }

        if (b_data.createAnswer2 && endVideo) {
            _QAManager.ShowQuestionAnswer(q_data.question2, a_data.answer2_1, a_data.answer2_2, a_data.answer2_3, a_data.answer2_4, a_data.numberOfAnswers2);

            foreach (GameObject answer in answerSystem) {
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer2_1) {
                    SceneManager.LoadScene("Video2-1");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer2_2) {
                    SceneManager.LoadScene("Video2-2");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer2_3) {
                    SceneManager.LoadScene("Video2-3");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer2_4) {
                    SceneManager.LoadScene("Video2-4");
                }
            }
        }
    }

    void Sequence_3() {
        if (!b_data.createAnswer3 && endVideo) {
            SceneManager.LoadScene("NextVideo3");
        }

        if (b_data.createAnswer3 && endVideo) {
            _QAManager.ShowQuestionAnswer(q_data.question3, a_data.answer3_1, a_data.answer3_2, a_data.answer3_3, a_data.answer3_4, a_data.numberOfAnswers3);

            foreach (GameObject answer in answerSystem) {
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer3_1) {
                    SceneManager.LoadScene("Video3-1");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer3_2) {
                    SceneManager.LoadScene("Video3-2");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer3_3) {
                    SceneManager.LoadScene("Video3-3");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer3_4) {
                    SceneManager.LoadScene("Video3-4");
                }
            }
        }
    }

    void Sequence_4() {
        if (!b_data.createAnswer4 && endVideo) {
            SceneManager.LoadScene("NextVideo4");
        }

        if (b_data.createAnswer4 && endVideo) {
            _QAManager.ShowQuestionAnswer(q_data.question4, a_data.answer4_1, a_data.answer4_2, a_data.answer4_3, a_data.answer4_4, a_data.numberOfAnswers4);

            foreach (GameObject answer in answerSystem) {
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer4_1) {
                    SceneManager.LoadScene("Video4-1");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer4_2) {
                    SceneManager.LoadScene("Video4-2");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer4_3) {
                    SceneManager.LoadScene("Video4-3");
                }
                if (answer.GetComponent<AnswerSystem>().answerGiven == a_data.answer4_4) {
                    SceneManager.LoadScene("Video4-4");
                }
            }
        }
    }
}
