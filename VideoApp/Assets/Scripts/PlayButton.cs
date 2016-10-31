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
    private string m_SceneToLoad;                      // The name of the scene to load.
    [SerializeField]
   // private ScreenFadeOut m_CameraFadeOut;
    private VRCameraFade m_CameraFade;                 // This fades the scene out when a new scene is about to be loaded.
    [SerializeField] 
    private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.
     

    private AudioSource audio;
    [SerializeField] private MediaPlayerCtrl videoPlayer;
    private Camera cameraToActivate;
    private Camera cameraToDisable;
    [SerializeField]private Image fadePanel;

    public Downloader downloader;
    public string videoName;

    private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.
    public bool buttonActivated = false;


    public void Start()
    {
        downloader.downloadFinished = true;
       // videoPlayer = GameObject.Find("sphere").GetComponent<MediaPlayerCtrl>();
        cameraToActivate = GameObject.FindGameObjectWithTag("VideoCamera").GetComponent<Camera>();
        cameraToDisable = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
       // fadePanel = GameObject.FindGameObjectWithTag("V_FadePanel").GetComponent<Image>();
        m_CameraFade = cameraToDisable.GetComponent<VRCameraFade>();
        audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        
    }

    void Update()
    {
        m_SelectionRadial = GameObject.Find("MainCamera").GetComponent<SelectionRadial>();
        //  m_CameraFadeOut = GameObject.Find("MainCamera").GetComponent<ScreenFadeOut>();
        if(buttonActivated)
            videoPlayer.m_strFileName = "file:///" + downloader.downloader.downloadDirectory + "/" + videoName + ".mp4";

        Debug.Log("Download directory: " + videoPlayer.m_strFileName);
        
        
    }

    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
        
        Debug.Log("Enabled");
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_SelectionRadial.OnSelectionComplete -= HandleSelectionComplete;
        
        Debug.Log("Disabled");
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
        if (m_GazeOver)
            StartCoroutine(ActivateButton());
    }


    private IEnumerator ActivateButton()
    {
        // If the camera is already fading, ignore.
        if (m_CameraFade.IsFading)
            yield break;

        // If anything is subscribed to the OnButtonSelected event, call it.
        if (OnButtonSelected != null)
            OnButtonSelected(this);

        // Wait for the camera to fade out.
        yield return StartCoroutine(m_CameraFade.BeginFadeOut(true));

        m_CameraFade.enabled = false;
        cameraToActivate.enabled = true;
        cameraToDisable.enabled = false;
        audio.mute = true;
        videoPlayer.enabled = true;
        fadePanel.color = Color.clear;
        buttonActivated = true;
    }
}