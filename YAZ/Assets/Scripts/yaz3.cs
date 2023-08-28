using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class yaz3 : MonoBehaviour
{
    [SerializeField] float speed;
    //private Vector3 LimitPos;
    //private Rigidbody rb;
    Vector3 push = Vector3.up;
    [SerializeField] float avance;
    //[SerializeField] float force;
    [SerializeField] float giro;

    //TEST GAMEMANAGER
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Alternativa con cilindro 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Space")
        {
            //Destroy(this.gameObject);
            Debug.Log("Nave destruida");        }
    }

    // Update is called once per frame
    void Update()
    {
        float PosY = transform.position.y;
        //Debug.Log(PosY);
        float PosX = transform.position.x;
        // El nuevo booleano 
        bool Final = PosY <= 20f && PosY >= -5f && PosX <= 8f && PosX >= -8f;

        //Debug.Log(PosX);

        if (Final == true)
        {
           // Para que se mueva en vertical  
            
            float desplY = Input.GetAxis("Vertical");
            transform.Translate(push * desplY * speed * Time.deltaTime);

            // Para que se mueva en horizontal 
            float desplX = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * desplX * speed * Time.deltaTime);

            // Para que rote en X 
            if (Input.GetKey(KeyCode.A))
            {
                // OLD: transform.Rotate(Vector3.up * giro * Time.deltaTime);
                transform.Rotate(Vector3.forward * giro * Time.deltaTime);
            }

            // Para que rote en X en sentido contrario 

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.back * giro * Time.deltaTime);
            }
            // Para que rote en Y 
            if (Input.GetKey(KeyCode.W))
            {
                // OLD: transform.Rotate(Vector3.up * giro * Time.deltaTime);
                transform.Rotate(Vector3.left * giro * Time.deltaTime);
            }

            // Para que rote en Y en sentido contrario 

            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(Vector3.right * giro * Time.deltaTime);
            }


            // Para avanzar en Z 

            //rb.AddForce(push * force);

            float desplZ = Input.GetAxis("Jump");
            transform.Translate(Vector3.forward * desplZ * avance * Time.deltaTime);

            //Para que vuelva al punto inicial

            /*LimitPos = transform.position;
            transform.position = Vector3.zero;*/

            //Cosas de antes 

            /*transform.Translate(Vector3.down * desplY * speed * Time.deltaTime);
            Debug.Log("LÍMITE ALTO");
            transform.Translate(Vector3.up * desplY * speed * Time.deltaTime);
            Debug.Log("LÍMITE BAJO");*/


            /*else if (PosX > 8f || PosX < -8f)
            {
                LimitPos = transform.position;
                transform.position = Vector3.zero;

            }*/
        }
        else if (Final == false)
        {
            transform.position = Vector3.zero;
            //FindObjectOfType<GameManager>().EndGame2();

        }

    }
}
