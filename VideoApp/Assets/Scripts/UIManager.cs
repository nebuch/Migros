using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using VRStandardAssets.Utils;
using VRStandardAssets.Menu;

public class UIManager : MonoBehaviour {

    [SerializeField] private VRInput m_VRInput;
    [SerializeField] private MenuButton m_MenuButton;
    [SerializeField] private DownloadButton m_DownloadButton;

    public GameObject info;
    public GameObject loadingBar;
    public MenuManager manager;
    public Text text;
   
    private void OnEnable()
    {
        m_VRInput.OnCancel += HandleCancel;

        text.text = 
    }


    private void OnDisable()
    {
        m_VRInput.OnCancel -= HandleCancel;
    }


    private void HandleCancel()
    {
        GoToFirstMenu();
    }

    
    private void GoToFirstMenu()
    {
        info.SetActive(false);
  
        m_MenuButton.infoActive = false;
        manager.EnableUI();
    }

}
