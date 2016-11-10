using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RPB : MonoBehaviour
{
    public Transform LoadingBar;
    public Transform TextIndicator;
    public Transform TextLoading;
    [SerializeField]
    private float currentAmount;
    [SerializeField]
    private float speed;

    public Downloader downloader;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(downloader.downloadFinished == false)
        {
            currentAmount = downloader.progressValue;
            TextIndicator.GetComponent<Text>().text = ((int)currentAmount).ToString() + "%";
            TextLoading.gameObject.SetActive(true);
        }
        
        LoadingBar.GetComponent<Image>().fillAmount = currentAmount / 100;
    }
}
