using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;


public class PlayButton : MonoBehaviour
{
    public event Action<PlayButton> OnButtonSelected;                   // This event is triggered when the selection of the button has finished.

    [SerializeField]
    private VRCameraFade m_CameraFade;                 // This fades the scene out when a new scene is about to be loaded.
    [SerializeField] 
    private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.
     

  //  private AudioSource audio;
    public VideoLoader videoLoader;
    public GameObject sceneToActivate;
	public GameObject sceneToDisable;
    [SerializeField]private Image fadePanel;

    public Downloader downloader;
    public string videoName;

    private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.
    public bool buttonActivated = false;
    public Text text;

    public void Start()
    {
       // downloader.downloadFinished = true;
       // videoPlayer = GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>();
       // cameraToActivate = GameObject.FindGameObjectWithTag("VideoCamera").GetComponent<Camera>();
       // cameraToDisable = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
       // fadePanel = GameObject.FindGameObjectWithTag("V_FadePanel").GetComponent<Image>();
       // m_CameraFade = cameraToDisable.GetComponent<VRCameraFade>();
       // audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        
    }

    void Update()
    {
        m_SelectionRadial = GameObject.Find("MainCamera").GetComponent<SelectionRadial>();
        //  m_CameraFadeOut = GameObject.Find("MainCamera").GetComponent<ScreenFadeOut>();
         
    }

    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
        StartCoroutine(ActivateButton()); //Temporary
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_SelectionRadial.OnSelectionComplete -= HandleSelectionComplete;
    }


    private void HandleOver()
    {
        // When the user looks at the rendering of the scene, show the radial.
        m_SelectionRadial.Show();

        m_GazeOver = true;
    }


    private void HandleOut()
    {
        // When the user looks away from the rendering of the scene, hide the radial.
        m_SelectionRadial.Hide();

        m_GazeOver = false;
    }


    private void HandleSelectionComplete()
    {
        // If the user is looking at the rendering of the scene when the radial's selection finishes, activate the button.
       /* if (m_GazeOver)
            StartCoroutine(ActivateButton());*/
    }

    private IEnumerator ActivateButton()
    {
        // If the camera is already fading, ignore.
        if (m_CameraFade.IsFading)
            yield break;

        // If anything is subscribed to the OnButtonSelected event, call it.
        if (OnButtonSelected != null)
            OnButtonSelected(this);
#if UNITY_EDITOR
       // videoLoader._currentVideo = videoName + ".mp4";
#endif
#if UNITY_ANDROID && !UNITY_EDITOR
      //  videoLoader._currentVideo = "file:///" + Application.persistentDataPath + "/" + videoName + ".mp4";
#endif
       // PlayerPrefs.SetString("video", videoLoader._currentVideo);

        // Wait for the camera to fade out.
        yield return StartCoroutine(m_CameraFade.BeginFadeOut(true));

        m_CameraFade.enabled = false;
        sceneToActivate.SetActive(true);
		sceneToDisable.SetActive (false);
        fadePanel.color = Color.clear;
        buttonActivated = true;

    }
}