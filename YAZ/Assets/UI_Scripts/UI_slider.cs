using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_slider : MonoBehaviour
{
    [SerializeField] Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.value = .50f;
    }

    // Update is called once per frame
    void Update()
    {
        print(slider.value);
    }
}
