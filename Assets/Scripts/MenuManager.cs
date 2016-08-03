using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;
using System.Collections;
using VRStandardAssets.Menu;

public class MenuManager : MonoBehaviour {

    public GameObject[] videos;
    public GameObject[] infos;
    public MenuButton[] menuButton;
    public DownloadButton[] downloadButton;
    public PlayButton[] playButton;
    public TrashButton[] trashButton;

    // Use this for initialization
    void Awake () {

        DontDestroyOnLoad(transform.gameObject);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }

        
            

    }
	
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


        Invoke("DisableButtons", 0.1f);
        Invoke("EnableButtons", 0.3f);

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
        for (int i = 0; i < videos.Length; i++)
        {
            videos[i].GetComponent<MeshRenderer>().enabled = false;
            videos[i].GetComponent<MeshCollider>().enabled = false;
        }
    }
}
