using UnityEngine;
using System.Collections;
using LitJson;
using System;

public class BooleanData : MonoBehaviour 
{
    public bool createAnswer;
    public bool createAnswer1;
    public bool createAnswer2;
    public bool createAnswer3;
    public bool createAnswer4;

    [SerializeField] private ReadJson booleanData;
    private JsonData data;

    // Use this for initialization
    void Start () {
        booleanData = FindObjectOfType<ReadJson>();
        data = booleanData.GetData();
        InitializeBooleanData();
    }

    private void InitializeBooleanData() {
        createAnswer = (bool)data["createAnswer"];
        createAnswer1 = (bool)data["createAnswer1"];
        createAnswer2 = (bool)data["createAnswer2"];
        createAnswer3 = (bool)data["createAnswer3"];
        createAnswer4 = (bool)data["createAnswer4"];
    }
}
