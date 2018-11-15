using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class M_Pause : MonoBehaviour {
    AudioSource m_MyAudioSource;
    public Button BtnPP;
    public Sprite BtnCCfor;
    public Button BtnCopy;
    private Button BtnCC;
    var 

    //Play the music
    bool m_Play;

    void Start()
    {
        BtnCC = Instantiate(BtnCopy);
        BtnCC.transform.parent = BtnCopy.transform.parent;
        BtnCC.transform.localPosition = new Vector2(-300, -300);
        BtnCC.name = "BtnChange";
        BtnCC.GetComponent<Image>().sprite = BtnCCfor;
        BtnCC.transform.GetChild(0).GetComponent<Image>().sprite = BtnCCfor;

        BtnCC.onClick.AddListener(BtnCCOnclick);
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
    void BtnCCOnclick() {
        Debug.Log("BtnCCOnClick");
        Debug.Log("d0v0b");
        AudioClip clip = Resources.Load<AudioClip>("Sounds/Awakening");
        m_MyAudioSource.clip = clip;
        m_MyAudioSource.Play();
    }
}
