using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Collections;
using LitJson;

public class ReadJson : MonoBehaviour {
    private string filePath;
    private JsonData queData;
    private JsonData data;
    
    private string jsonString;
    private string sceneName;

    void Awake () {
        StartCoroutine(Json());
        queData = JsonMapper.ToObject(jsonString);
        data = queData[0]["data"];
        
    }

    public JsonData GetData() {
        return data;
    }

    private void GetCurrentJsonToRead() {
        sceneName = SceneManager.GetActiveScene().name;
        switch (sceneName) {
            case "Slaughterhouse":
                filePath = Path.Combine(Application.persistentDataPath, "Slaughterhouse.json");
                PlayerPrefs.SetString("path", filePath);
                break;
            case "Bakery":
                filePath = Path.Combine(Application.persistentDataPath, "Bakery.json");
                PlayerPrefs.SetString("path", filePath);
                break;
            case "Checkout":
                filePath = Path.Combine(Application.persistentDataPath, "Checkout.json");
                PlayerPrefs.SetString("path", filePath);
                break;                                    
            case "Grocery":
                filePath = Path.Combine(Application.persistentDataPath, "Grocery.json");
                PlayerPrefs.SetString("path", filePath);
                break;                                    
            case "Hygene":
                filePath = Path.Combine(Application.persistentDataPath, "Hygene.json");
                PlayerPrefs.SetString("path", filePath);
                break;                                    
            case "Logistics":
                filePath = Path.Combine(Application.persistentDataPath, "Logistics.json");
                PlayerPrefs.SetString("path", filePath);
                break;
            case "Video1":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video1-1":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video1-2":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video1-3":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video1-4":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video2":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video2-1":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video2-2":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video2-3":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video2-4":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video3":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video3-1":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video3-2":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video3-3":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video3-4":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video4":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video4-1":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video4-2":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video4-3":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "Video4-4":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "NextVideo0":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "NextVideo1":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "NextVideo2":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "NextVideo3":
                filePath = PlayerPrefs.GetString("path");
                break;
            case "NextVideo4":
                filePath = PlayerPrefs.GetString("path");
                break;


        }


    }

    IEnumerator Json() {
        GetCurrentJsonToRead();
        if (filePath.Contains("://")) {
            WWW www = new WWW(filePath);
            yield return www;
            jsonString = www.text;
        }
        else {
            jsonString = System.IO.File.ReadAllText(filePath);
        }
    }
}
