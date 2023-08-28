using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz6 : MonoBehaviour
{

    private Vector3 InitPos;
    [SerializeField] Vector3 DestPos;
    private Vector3 FinalPos;
    public float speed = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //MOVER EN Z los obstáculos
        InitPos = transform.position;
        FinalPos = InitPos + DestPos * Time.deltaTime * speed;
        transform.position = FinalPos;

    }
}
