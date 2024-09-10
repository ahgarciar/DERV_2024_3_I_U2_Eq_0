using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S8_DestruyeObjetos2 : MonoBehaviour
{
   [SerializeField] TextMeshProUGUI texto_puntuacion;
    public int contador;

   private void Start() {
    contador = 0;
   }

     private void OnCollisionEnter(Collision other) {
        GameObject objeto = other.gameObject;
        //if (objeto.name != "Plane" && objeto.name != "Muro" && objeto.name != "Muro2") {
        if (!objeto.CompareTag("NoRompible")) {
            contador++;
            texto_puntuacion.text = contador.ToString();
            Destroy(objeto);
        }
    }
}
