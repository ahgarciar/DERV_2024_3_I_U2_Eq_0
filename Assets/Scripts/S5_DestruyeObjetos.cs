using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DestruyeObjetos : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision other) {
        GameObject objeto = other.gameObject;
        //if (objeto.name != "Plane" && objeto.name != "Muro" && objeto.name != "Muro2") {
        if (!objeto.CompareTag("NoRompible")) {
            Destroy(objeto);
        }
    }


}
