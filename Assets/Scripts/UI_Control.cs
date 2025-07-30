using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Control : MonoBehaviour
{
    [SerializeField] GameObject Logo;
    [SerializeField] GameObject MM_Buttons,Music, Music_Mute, Sound, Sound_Mute;
    [SerializeField] GameObject Single_Panel, Multi_Panel_Offline, Multi_Panel_Online;
    [SerializeField] GameObject Settings_Panel;
    private bool Music_on, Sound_on;

    void Start()
    {
        Music_on = true;
        Sound_on = true;
        Logo.SetActive(true);
        MM_Buttons.SetActive(true);
        Single_Panel.SetActive(false);
        Multi_Panel_Offline.SetActive(false);
        Multi_Panel_Online.SetActive(false);
        Settings_Panel.SetActive(false);
    }


    void Update()
    {
        
    }

    public void Single_Button()
    {
        Logo.SetActive(false);
        MM_Buttons.SetActive(false);
        Multi_Panel_Offline.SetActive(false);
        Multi_Panel_Online.SetActive(false);
        Single_Panel.SetActive(true);
    }
    public void Multi_Button_Offline()
    {
        Logo.SetActive(false);
        MM_Buttons.SetActive(false);
        Single_Panel.SetActive(false);
        Multi_Panel_Online.SetActive(false);
        Multi_Panel_Offline.SetActive(true);
    }

    public void Multi_Button_Online()
    {
        Logo.SetActive(false);
        MM_Buttons.SetActive(false);
        Single_Panel.SetActive(false);
        Multi_Panel_Offline.SetActive(false);
        Multi_Panel_Online.SetActive(true);
    }

    public void Back_Button()
    {
        Single_Panel.SetActive(false);
        Multi_Panel_Offline.SetActive(false);
        Multi_Panel_Online.SetActive(false);
        Settings_Panel.SetActive(false);
        Logo.SetActive(true);
        MM_Buttons.SetActive(true);
    }
    public void Settings_Button()
    {
        Single_Panel.SetActive(false);
        Multi_Panel_Offline.SetActive(false);
        Multi_Panel_Online.SetActive(false);
        Logo.SetActive(false);
        MM_Buttons.SetActive(false);
        Settings_Panel.SetActive(true);
    }
    public void Music_Button()
    {
        if (Music_on)
        {
            Music.SetActive(false);
            Music_Mute.SetActive(true);
            Music_on = false;
        }
        else
        {
            Music_Mute.SetActive(false);
            Music.SetActive(true);
            Music_on = true;
        }
    }

    public void Sound_Button()
    {
        if (Sound_on)
        {
            Sound.SetActive(false);
            Sound_Mute.SetActive(true);
            Sound_on = false;
        }
        else
        {
            Sound_Mute.SetActive(false);
            Sound.SetActive(true);
            Sound_on = true;
        }
    }

}
