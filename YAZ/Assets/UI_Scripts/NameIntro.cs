using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameIntro : NameTransfer
{
    public NameTransfer nameTransfer;
    public TextMeshProUGUI TXT;

    void Start()
    {
        nameTransfer.StoreName();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
