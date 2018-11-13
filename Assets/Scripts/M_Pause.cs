using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class M_Pause : MonoBehaviour {
    AudioSource m_MyAudioSource;
    public Button BtnPP;

    //Play the music
    bool m_Play;

    void Start()
    {
        BtnPP.onClick.AddListener(BtnPPOnclick);
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        //Ensure the toggle is set to true for the music to play at start-up
        m_Play = true;
    }

    void Update()
    {
        try
        {
            if (m_Play == true)
            {
                m_MyAudioSource.UnPause();
            }
            else
            {
                m_MyAudioSource.Pause();
            }
        }catch(Exception exp)
        {
            Debug.LogError(exp.ToString());
        }
    }

    void OnGUI()
    {
       
    }
    void BtnPPOnclick() {
        Debug.Log("BtnMMOnClick");
        if (m_Play == true)
        {
            m_Play = false;
        }
        else
        {
            m_Play = true;
        }
    }
}
