using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QAManager : MonoBehaviour 
{
    public GameObject question;
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;

    public Text questionText;
    public Text questionText1;
    public Text questionText2;
    public Text questionText3;
    public Text questionText4;

    public GameObject answer1;
    public GameObject answer1_1;
    public GameObject answer1_2;
    public GameObject answer1_3;
    public GameObject answer1_4;

    public Text answer1Text;
    public Text answer1Text1;
    public Text answer1Text2;
    public Text answer1Text3;
    public Text answer1Text4;

    public GameObject answer2;
    public GameObject answer2_1;
    public GameObject answer2_2;
    public GameObject answer2_3;
    public GameObject answer2_4;

    public Text answer2Text;
    public Text answer2Text1;
    public Text answer2Text2;
    public Text answer2Text3;
    public Text answer2Text4;

    public GameObject answer3;
    public GameObject answer3_1;
    public GameObject answer3_2;
    public GameObject answer3_3;
    public GameObject answer3_4;

    public Text answer3Text;
    public Text answer3Text1;
    public Text answer3Text2;
    public Text answer3Text3;
    public Text answer3Text4;

    public GameObject answer4;
    public GameObject answer4_1;
    public GameObject answer4_2;
    public GameObject answer4_3;
    public GameObject answer4_4;


    public Text answer4Text;
    public Text answer4Text1;
    public Text answer4Text2;
    public Text answer4Text3;
    public Text answer4Text4;

    public void ShowQuestionAnswer(string _question, string ans1, string ans2, string ans3, string ans4, int _numberOfAnswers) {
        question.SetActive(true);
        questionText.text = _question;
        answer1.SetActive(true);
        answer1Text.text = ans1;
        answer2.SetActive(true);
        answer2Text.text = ans2;

        if(_numberOfAnswers > 2) {
            answer3.SetActive(true);
            answer3Text.text = ans3;
        }
            
        if(_numberOfAnswers > 3) {
            answer4.SetActive(true);
            answer4Text.text = ans4;
        }
            
        
    }

    public void ShowQuestionAnswer1(string _question, string ans1, string ans2, string ans3, string ans4, int _numberOfAnswers) {
        question1.SetActive(true);
        questionText1.text = _question;
        answer1_1.SetActive(true);
        answer1Text1.text = ans1;
        answer2_1.SetActive(true);
        answer2Text1.text = ans2;

        if (_numberOfAnswers > 2) {
            answer3_1.SetActive(true);
            answer3Text1.text = ans3;
        }

        if (_numberOfAnswers > 3) {
            answer4_1.SetActive(true);
            answer4Text1.text = ans4;
        }


    }

    public void ShowQuestionAnswer2(string _question, string ans1, string ans2, string ans3, string ans4, int _numberOfAnswers) {
        question2.SetActive(true);
        questionText2.text = _question;
        answer1_2.SetActive(true);
        answer1Text2.text = ans1;
        answer2_2.SetActive(true);
        answer2Text2.text = ans2;

        if (_numberOfAnswers > 2) {
            answer3_2.SetActive(true);
            answer3Text2.text = ans3;
        }

        if (_numberOfAnswers > 3) {
            answer4_2.SetActive(true);
            answer4Text2.text = ans4;
        }


    }

    public void ShowQuestionAnswer3(string _question, string ans1, string ans2, string ans3, string ans4, int _numberOfAnswers) {
        question3.SetActive(true);
        questionText3.text = _question;
        answer1_3.SetActive(true);
        answer1Text3.text = ans1;
        answer2_3.SetActive(true);
        answer2Text3.text = ans2;

        if (_numberOfAnswers > 2) {
            answer3_3.SetActive(true);
            answer3Text3.text = ans3;
        }

        if (_numberOfAnswers > 3) {
            answer4_3.SetActive(true);
            answer4Text3.text = ans4;
        }


    }

    public void ShowQuestionAnswer4(string _question, string ans1, string ans2, string ans3, string ans4, int _numberOfAnswers) {
        question4.SetActive(true);
        questionText4.text = _question;
        answer1_4.SetActive(true);
        answer1Text4.text = ans1;
        answer2_4.SetActive(true);
        answer2Text4.text = ans2;

        if (_numberOfAnswers > 2) {
            answer3_4.SetActive(true);
            answer3Text4.text = ans3;
        }

        if (_numberOfAnswers > 3) {
            answer4_4.SetActive(true);
            answer4Text4.text = ans4;
        }


    }

    public void HideQuestionAnswer() {
        question.SetActive(false);
        answer1.SetActive(false);
        answer2.SetActive(false);
        answer3.SetActive(false);
        answer4.SetActive(false);
    }

    public void HideQuestionAnswer1() {
        question1.SetActive(false);
        answer1_1.SetActive(false);
        answer2_1.SetActive(false);
        answer3_1.SetActive(false);
        answer4_1.SetActive(false);
    }

    public void HideQuestionAnswer2() {
        question2.SetActive(false);
        answer1_2.SetActive(false);
        answer2_2.SetActive(false);
        answer3_2.SetActive(false);
        answer4_2.SetActive(false);
    }

    public void HideQuestionAnswer3() {
        question3.SetActive(false);
        answer1_3.SetActive(false);
        answer2_3.SetActive(false);
        answer3_3.SetActive(false);
        answer4_3.SetActive(false);
    }

    public void HideQuestionAnswer4() {
        question4.SetActive(false);
        answer1_4.SetActive(false);
        answer2_4.SetActive(false);
        answer3_4.SetActive(false);
        answer4_4.SetActive(false);
    }
}
