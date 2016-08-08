using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Menu
{
    // This script is for loading scenes from the main menu.
    // Each 'button' will be a rendering showing the scene
    // that will be loaded and use the SelectionRadial.
    public class MenuButton : MonoBehaviour
    {
        public event Action<MenuButton> OnButtonSelected;                   // This event is triggered when the selection of the button has finished.

        [SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
        [SerializeField] private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.
        [SerializeField] private MenuManager manager;

        public GameObject videoInfo;                                        //The info item, for where each video information is shown.
        public MediaPlayerCtrl videoPlayer;

        public bool infoActive;
        private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.

        void Update()
        {
            m_SelectionRadial = GameObject.Find("MainCamera").GetComponent<SelectionRadial>();
            this.gameObject.SetActive(true);
            videoPlayer.m_strFileName = null;
        }

        private void OnEnable ()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
            m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
        }


        private void OnDisable ()
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
            if(m_GazeOver)
               ActivateButton();
        }


        private void ActivateButton()
        {
            // If anything is subscribed to the OnButtonSelected event, call it.
            if (OnButtonSelected != null)
                OnButtonSelected(this);


            GotoInfo();
            
        }

        private void GotoInfo()
        {
            //Disable thumbnails and enable information
            videoInfo.SetActive(true);
            
            infoActive = true;
            manager.DisableUI();
            

        }
    }
}