using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_MusicSlider : MonoBehaviour
{
    [SerializeField] Slider mySlider; 
    void Start()
    {
        if(PlayerPrefs.HasKey("GameVolume"))
        {
            mySlider.value = PlayerPrefs.GetFloat("GameVolume");
        }
        else
        {
            mySlider.value = .50f; 
        }

    }

    // Update is called once per frame
    public void SliderUpdate()
    {
       PlayerPrefs.SetFloat("GameVolume", mySlider.value);
    }

}
