using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using LitJson;

public class QuestionData : MonoBehaviour 
{
    public string question0;
    public string question1;
    public string question2;
    public string question3;
    public string question4;

    [SerializeField] private ReadJson questionData;
    private JsonData data;

    // Use this for initialization
    void Start () {
        questionData = FindObjectOfType<ReadJson>();
        data = questionData.GetData();
        InitializeQuestionData();
    }
	
	private void InitializeQuestionData() {
        question0 = data["question0"].ToString();
        question1 = data["question1"].ToString();
        question2 = data["question2"].ToString();
        question3 = data["question3"].ToString();
        question4 = data["question4"].ToString();
    }
}
