using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionTriggers : MonoBehaviour
{
    Renderer rend;
    Material material;
    Material m_original;
    [SerializeField] GameObject plancha_resultado;

    private void Start() {
        rend = GetComponent<Renderer>();
        material = rend.material;
        m_original = plancha_resultado.GetComponent<Renderer>().material;
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("T. Enter" + other.gameObject.name);
        plancha_resultado.GetComponent<Renderer>().material = material;
    }

    private void OnTriggerStay(Collider other) {
        Debug.Log("T. Stay" + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other) {
        Debug.Log("T. Exit" + other.gameObject.name);
        plancha_resultado.GetComponent<Renderer>().material = m_original;
    }

}
