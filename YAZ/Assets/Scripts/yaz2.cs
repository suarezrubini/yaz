using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz2 : MonoBehaviour
{
    [SerializeField] Transform objetivo;
    void Start()
    {
        
    }
    void Update()
    {
        transform.LookAt(objetivo);
    }
}
