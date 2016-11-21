using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using System.Collections;
using VRStandardAssets.Menu;

public class MenuManager : MonoBehaviour {

    //private static MenuManager m_Instance;

    public GameObject[] videos;
    public GameObject[] infos;
    public MenuButton[] menuButton;
    public DownloadButton[] downloadButton;
    public PlayButton[] playButton;
    public TrashButton[] trashButton;


    /*public static MenuManager Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = FindObjectOfType<MenuManager>();
                DontDestroyOnLoad(m_Instance.gameObject);
            }

            return m_Instance;
        }
    }*/

    /*private void Awake()
    {
        if (m_Instance == null)
        {
            m_Instance = this;
            DontDestroyOnLoad(this);
        }
        else if (this != m_Instance)
        {
            Destroy(gameObject);
        }
    }*/

	// Update is called once per frame
	 public void Update ()
    {
       /* if (SceneManager.GetActiveScene().name == "MainMenu" && !SceneManager.GetActiveScene().isLoaded)
        {
            foreach(GameObject info in infos)
            {
                info.SetActive(true);
            }
        }
        else
        {
            foreach (GameObject info in infos)
            {
                info.SetActive(false);
            }
        }*/


      //  Invoke("DisableButtons", 0.1f);
      //  Invoke("EnableButtons", 0.3f);

    }

    public void DisableButtons()
    {
        foreach (MenuButton m_button in menuButton)
        {
            m_button.enabled = false;
        }

        foreach (DownloadButton d_button in downloadButton)
        {
            d_button.enabled = false;
        }

        foreach (PlayButton p_button in playButton)
        {
            p_button.enabled = false;
        }

        foreach (TrashButton t_button in trashButton)
        {         
            t_button.enabled = false;

        }
        
    }

    public void EnableButtons()
    {
        foreach (MenuButton m_button in menuButton)
        {
            m_button.enabled = true;
        }

        foreach (DownloadButton d_button in downloadButton)
        {
            d_button.enabled = true;
        }

        foreach (PlayButton p_button in playButton)
        {
            p_button.enabled = true;
        }

        foreach (TrashButton t_button in trashButton)
        {
            t_button.enabled = true;

        }
    }

    public void EnableUI()
    {
        for (int i = 0; i < videos.Length; i++)
        {
            videos[i].GetComponent<MeshRenderer>().enabled = true;
            videos[i].GetComponent<MeshCollider>().enabled = true;
        }
    }

    public void DisableUI()
    {
        for (int i = 0; i < menuButton.Length; i++)
        {
            menuButton[i].GetComponent<MeshRenderer>().enabled = false;
            menuButton[i].GetComponent<MeshCollider>().enabled = false;
        }
    }
}
