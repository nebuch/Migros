using UnityEngine;
using System;
using System.IO;
using VRStandardAssets.Utils;

public class TrashButton : MonoBehaviour
{
    public event Action<TrashButton> OnButtonSelected;

    [SerializeField] private SelectionRadial m_SelectionRadial;         // This controls when the selection is complete.
    [SerializeField] private VRInteractiveItem m_InteractiveItem;       // The interactive item for where the user should click to load the level.

    private bool m_GazeOver;                                            // Whether the user is looking at the VRInteractiveItem currently.

    public string filePathToDelete;

    void Update()
    {
        m_SelectionRadial = GameObject.Find("MainCamera").GetComponent<SelectionRadial>();
    }

    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_SelectionRadial.OnSelectionComplete += HandleSelectionComplete;
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
        if (m_GazeOver)
            DeleteFile();
    }

    private void DeleteFile()
    {
        // If anything is subscribed to the OnButtonSelected event, call it.
        if (OnButtonSelected != null)
            OnButtonSelected(this);

        File.Delete(filePathToDelete);

    }
}
