using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz2rot: MonoBehaviour
{
    [SerializeField] GameObject OtherObj;
    public float speedRot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    Vector3 rotacion = new Vector3(0f, 0f, 0f);
    OtherObj.transform.Rotate(Vector3.right * speedRot * Time.deltaTime);
    }
}
