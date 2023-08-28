using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameTransfer : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI user_name;
    [SerializeField] TMP_InputField user_inputField;

    public void StoreName()
    {
        user_name.text = "Bienvenido " + user_inputField.text;
    }
}