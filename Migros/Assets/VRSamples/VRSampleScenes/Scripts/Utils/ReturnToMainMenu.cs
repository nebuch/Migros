using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace VRStandardAssets.Utils
{
    // This class simply allows the user to return to the main menu.
    public class ReturnToMainMenu : MonoBehaviour
    {
        [SerializeField]
        private string m_MenuSceneName = "MainMenu";   // The name of the main menu scene.
        [SerializeField]
        private VRInput m_VRInput;                     // Reference to the VRInput in order to know when Cancel is pressed.
        [SerializeField]
        private VRCameraFade m_VRCameraFade;           // Reference to the script that fades the scene to black.
        [SerializeField]
        private VRCameraFade m_ScreenFadeIn;

        public GameObject sceneToActivate;
        public GameObject sceneToDisable;
       // private AudioSource audio;

        public bool goToMenu = false;

        void Start()
        {
           // sceneToActivate = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
            //cameraToDisable = GameObject.FindGameObjectWithTag("VideoCamera").GetComponent<Camera>();
           // m_ScreenFadeIn = cameraToActivate.GetComponent<VRCameraFade>();
         
           // audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
        }

        private void OnEnable()
        {
            m_VRInput.OnCancel += HandleCancel;

        }


        private void OnDisable()
        {
            m_VRInput.OnCancel -= HandleCancel;
        }


        private void HandleCancel()
        {
            StartCoroutine(GoToMenu());
            
        }


        private IEnumerator GoToMenu()
        {

            // Wait for the screen to fade out.
            yield return StartCoroutine(m_VRCameraFade.BeginFadeOut(true));

            sceneToActivate.SetActive(true);
            sceneToDisable.SetActive(false);
            m_ScreenFadeIn.enabled = true;
            goToMenu = true;
            GetComponent<AudioSource>().mute = false;
        }
    }
}