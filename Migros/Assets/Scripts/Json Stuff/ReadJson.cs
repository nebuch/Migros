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
                break;
            case "Bakery":
                filePath = Path.Combine(Application.persistentDataPath, "Bakery.json");
                break;
            case "Checkout":
                filePath = Path.Combine(Application.persistentDataPath, "Checkout.json");
                break;                                    
            case "Grocery":
                filePath = Path.Combine(Application.persistentDataPath, "Grocery.json");
                break;                                    
            case "Hygene":
                filePath = Path.Combine(Application.persistentDataPath, "Hygene.json");
                break;                                    
            case "Logistics":
                filePath = Path.Combine(Application.persistentDataPath, "Logistics.json");
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
