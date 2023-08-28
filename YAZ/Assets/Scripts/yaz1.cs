using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz1: MonoBehaviour
{
    [SerializeField] GameObject OtherObj;
    private Vector3 InitPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;
    public float speedInit = 0;


    void Start()
    {
        //Si quisieras rotar la nave desde un inicio 
        //Quaternion targetRotation = Quaternion.Euler(-90f, 0f, 0f);
        //OtherObj.transform.rotation = targetRotation;
        
        //Si quieres rotar la nave hacia la derecha 
        //OtherObj.transform.Rotate(Vector3.up);

        //Si queremos escalar 
        //OtherObj.transform.localScale = new Vector3(5f, 5f, 5f);

    }
    void Update()
    {
        InitPos = OtherObj.transform.position;
        FinalPos = InitPos + DestPos * Time.deltaTime * speedInit;
        OtherObj.transform.position = FinalPos;
    }

}
