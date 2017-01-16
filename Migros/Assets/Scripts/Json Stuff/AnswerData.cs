using UnityEngine;
using System.Collections;
using LitJson;
using System;

public class AnswerData : MonoBehaviour 
{
    [SerializeField] private ReadJson answerData;
    private JsonData data;

    public int numberOfAnswers;
    public int numberOfAnswers1;
    public int numberOfAnswers2;
    public int numberOfAnswers3;
    public int numberOfAnswers4;

    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;

    public string answer1_1;
    public string answer1_2;
    public string answer1_3;
    public string answer1_4;

    public string answer2_1;
    public string answer2_2;
    public string answer2_3;
    public string answer2_4;

    public string answer3_1;
    public string answer3_2;
    public string answer3_3;
    public string answer3_4;
                        
    public string answer4_1;
    public string answer4_2;
    public string answer4_3;
    public string answer4_4;

    // Use this for initialization
    void Start () {
        answerData = FindObjectOfType<ReadJson>();
        data = answerData.GetData();
        InitializeAnswerData();
    }

    private void InitializeAnswerData() {
        answer1 = data["answer1"].ToString();
        answer2 = data["answer2"].ToString();
        answer3 = data["answer3"].ToString();
        answer4 = data["answer4"].ToString();

        answer1_1 = data["answer1-1"].ToString();
        answer1_2 = data["answer1-2"].ToString();
        answer1_3 = data["answer1-3"].ToString();
        answer1_4 = data["answer1-4"].ToString();

        answer2_1 = data["answer2-1"].ToString();
        answer2_2 = data["answer2-2"].ToString();
        answer2_3 = data["answer2-3"].ToString();
        answer2_4 = data["answer2-4"].ToString();

        answer3_1 = data["answer3-1"].ToString();
        answer3_2 = data["answer3-2"].ToString();
        answer3_3 = data["answer3-3"].ToString();
        answer3_4 = data["answer3-4"].ToString();

        answer4_1 = data["answer4-1"].ToString();
        answer4_2 = data["answer4-2"].ToString();
        answer4_3 = data["answer4-3"].ToString();
        answer4_4 = data["answer4-4"].ToString();

        numberOfAnswers = (int)data["numberOfAnswers"];
        numberOfAnswers1 = (int)data["numberOfAnswers1"];
        numberOfAnswers2 = (int)data["numberOfAnswers2"];
        numberOfAnswers3 = (int)data["numberOfAnswers3"];
        numberOfAnswers4 = (int)data["numberOfAnswers4"];
    }
}
