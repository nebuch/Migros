using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QAManager : MonoBehaviour 
{
    public GameObject question;
    public Text questionText;
    public GameObject answer1;
    public Text answer1Text;
    public GameObject answer2;
    public Text answer2Text;
    public GameObject answer3;
    public Text answer3Text;
    public GameObject answer4;
    public Text answer4Text;

    // Use this for initialization
    void Start () {
       
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowQuestionAnswer(string _question, string ans1, string ans2, string ans3, string ans4, int _numberOfAnswers) {
        question.SetActive(true);
        questionText.text = _question;
        answer1.SetActive(true);
        answer1Text.text = ans1;
        answer2.SetActive(true);
        answer2Text.text = ans2;

        if(_numberOfAnswers == 3) {
            answer3.SetActive(true);
            answer3Text.text = ans3;
        }
            
        if(_numberOfAnswers == 4) {
            answer4.SetActive(true);
            answer4Text.text = ans4;
        }
            
        
    }

    public void HideQuestionAnswer() {
        question.SetActive(false);
        answer1.SetActive(false);
        answer2.SetActive(false);
        answer3.SetActive(false);
        answer4.SetActive(false);
    }

}
