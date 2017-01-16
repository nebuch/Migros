using UnityEngine;
using System.Collections;
using LitJson;
using System;

public class BooleanData : MonoBehaviour 
{
    public bool createAnswer1;
    public bool createAnswer2;
    public bool createAnswer3;
    public bool createAnswer4;
    public bool noQuestion0;
    public bool noQuestion1;
    public bool noQuestion2;
    public bool noQuestion3;
    public bool noQuestion4;

    [SerializeField] private ReadJson booleanData;
    private JsonData data;

    // Use this for initialization
    void Start () {
        booleanData = FindObjectOfType<ReadJson>();
        data = booleanData.GetData();
        InitializeBooleanData();
    }

    private void InitializeBooleanData() {
        createAnswer1 = (bool)data["createAnswer1"];
        createAnswer2 = (bool)data["createAnswer2"];
        createAnswer3 = (bool)data["createAnswer3"];
        createAnswer4 = (bool)data["createAnswer4"];
        noQuestion0 = (bool)data["noQuestion0"];
        noQuestion1 = (bool)data["noQuestion1"];
        noQuestion2 = (bool)data["noQuestion2"];
        noQuestion3 = (bool)data["noQuestion3"];
        noQuestion4 = (bool)data["noQuestion4"];
    }
}
