using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI levelcount;
    public GameObject panelcamera;
    void Start()
    {
        string Scenename = SceneManager.GetActiveScene().name;
        levelcount.text = "LEVEL " + Scenename;

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(wait());
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
        panelcamera.SetActive(false);
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
