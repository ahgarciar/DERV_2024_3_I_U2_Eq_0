using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class M1_ManagerUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_puntuacion;
    int puntuacion;


    [SerializeField] TextMeshProUGUI texto_tiempo;
    int tiempo;

    void Start(){
        puntuacion = 0;
        tiempo = 20; //20 segundos de juego
        StartCoroutine("controlTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void agregaPuntos(int puntos){
        puntuacion+= puntos;
        texto_puntuacion.text = puntuacion.ToString();
    }

    IEnumerator controlTiempo(){
        while (true)
        {
            tiempo--;
            texto_tiempo.text = tiempo.ToString();
            yield return new WaitForSeconds(0.25f);
        }

        
    }
}
