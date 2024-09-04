using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_MovRotCompuesto : MonoBehaviour
{
    [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;

    // Update is called once per frame
    void Update()
    {
        //arriba - abajo
        if(Input.GetKey(KeyCode.W)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }   else if(Input.GetKey(KeyCode.S)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.forward;
        }

        // izquierda - derecha
        if(Input.GetKey(KeyCode.A)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.right;
        }   else if(Input.GetKey(KeyCode.D)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;
        }

        //rotar izquiera - rotar derecha
        if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, velocidad_rotacion * Time.deltaTime, 0);
        }   else if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0, -1 * velocidad_rotacion * Time.deltaTime, 0);
        }

    }
}
