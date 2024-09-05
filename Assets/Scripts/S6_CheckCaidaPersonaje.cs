using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_CheckCaidaPersonaje : MonoBehaviour
{
    [SerializeField] Transform spawn;    

    // Update is called once per frame
    void Update()
    {
        float valor_y;
        valor_y = transform.position.y;

        if (valor_y < 0){
            transform.position = spawn.position;
        }

    }
}
