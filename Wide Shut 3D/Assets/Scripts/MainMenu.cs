using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject settingspanel,mainpanel,joystick,soundOn,soundOff;
    public Toggle mytoogle;
    
    void Start()
    {
        if (mytoogle.isOn)
        {
            joystick.SetActive(true);

        }
        else
        {
            joystick.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        int kayýtlýlevel = PlayerPrefs.GetInt("saved");//3.level
                                                       //istediðimiz sahneye geçirebiliyoruz isim ayný olmalý
        if (kayýtlýlevel == 0)
        {
            SceneManager.LoadScene(kayýtlýlevel + 1);//3.level
        }
        else
        {
            SceneManager.LoadScene(kayýtlýlevel);
        }
    }
    public void Settings()
    {
        settingspanel.SetActive(true);
        mainpanel.SetActive(false);
    }
    public void settingsquit()
    {
        settingspanel.SetActive(false);
        mainpanel.SetActive(true);
    }
    public void SoundOff()
    {
        AudioListener.volume = 1f;
        soundOn.SetActive(true);
        soundOff.SetActive(false);

    }
    public void SoundOn()
    {
        AudioListener.volume = 0f;
        soundOn.SetActive(false);
        soundOff.SetActive(true);

    }
    public void Toog()
    {
        if (mytoogle.isOn)
        {
            joystick.SetActive(true);

        }
        else
        {
            joystick.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
