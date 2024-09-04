using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1_Movimiento_Forma1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float constante_velocidad = 5; 
        if(Input.GetKey(KeyCode.W)){
            //transform.Translate(Vector3.forward);
            transform.Translate(constante_velocidad * Time.deltaTime * new Vector3(0,0,1)); 
        }
        if(Input.GetKey(KeyCode.S)){
            //transform.Translate(Vector3.forward);
            transform.Translate(constante_velocidad * -1 * Time.deltaTime * new Vector3(0,0,1)); 
        }
    }
}
