using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yaz4 : MonoBehaviour
{
    [SerializeField] GameObject MyPrefab;
    [SerializeField] Transform InitPos;
    Vector3 NewPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int y = 0;
        for (int i = 0; i < 10; i++)
        {
            Vector3 CambioPos = new Vector3(y, 0, 0);
            NewPos = InitPos.position + CambioPos;
            Instantiate(MyPrefab, NewPos, Quaternion.identity);
            y += 5;
        }
    }
}
