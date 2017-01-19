using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using VRStandardAssets.Utils;


public class AnswerSystem : MonoBehaviour 
{
    public event Action<AnswerSystem> OnAnswerSelected;

    [SerializeField] private VRCameraFade m_CameraFade;                 // This fades the scene out when a new scene is about to be loaded.
    [SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
    [SerializeField] private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.
    [SerializeField] private VideoLoader _videoLoader;
    [SerializeField] private QAManager _QAManager;

    private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.
    public string answerGiven;

	[Header ("Answer Attr.")]
	public int _questionID;
	public int _answerID;
	private int _packID;
	private string _userID;

	[Header ("Player")]
	public GameObject _eventSystem;
	private bool _selected;

    void Start() {
        _userID = PlayerPrefs.GetString("userID");
    }

    private void OnEnable() {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
    }

    private void OnDisable() {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_SelectionRadial.OnSelectionComplete -= HandleSelectionComplete;
    }

    private void HandleOver() {
        // When the user looks at the rendering of the scene, show the radial.
        m_SelectionRadial.Show();

        m_GazeOver = true;
    }


    private void HandleOut() {
        // When the user looks away from the rendering of the scene, hide the radial.
        m_SelectionRadial.Hide();

        m_GazeOver = false;
    }


    private void HandleSelectionComplete() {
        // If the user is looking at the rendering of the scene when the radial's selection finishes, activate the button.
        if (m_GazeOver)
            //StartCoroutine(LoadNextVideo());
            ThisAnswerGiven();
    }

	public void ThisAnswerGiven(){
       /* if (answerGiven == this.gameObject.GetComponent<Text>().text ||
            this.gameObject.name == "Answer2" ||
            this.gameObject.name == "Answer3" ||
            this.gameObject.name == "Answer4") {
            answerGiven = this.gameObject.name;*/
            answerGiven = this.gameObject.GetComponentInChildren<Text>().text;
          
             
        //}

        // _videoLoader.LoadVideo();
        //PlayerPrefs.SetString (string.Format ("{0}: {1:0}_ {2:0}: {3:0}_ {4:0}: {5:0}_ {6:0}: {7:0}", "user", _userID, "pack", _packID, "question", _questionID, "answer", _answerID), "Answer Given");

		//Debug.Log (string.Format ("{0}: {1:0}_ {2:0}: {3:0}_ {4:0}: {5:0}_ {6:0}: {7:0}", "user", _userID, "pack", _packID, "question", _questionID, "answer", _answerID));
	}

    
	





}
