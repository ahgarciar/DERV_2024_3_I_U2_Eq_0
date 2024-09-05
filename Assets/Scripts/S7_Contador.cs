using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S7_Contador : MonoBehaviour
{
    int cont;
    [SerializeField] TextMeshProUGUI texto_contador;
    // Start is called before the first frame update
    void Start()
    {
        cont = 10;
        StartCoroutine("corrutina_contador");
    }

    IEnumerator corrutina_contador(){
        while(cont>0){
            cont--;
            texto_contador.text = cont.ToString();
            yield return new WaitForSeconds(0.5f);
        }

        //SceneManager.LoadScene(7); ..... ME LLEVE A UNA ESCENA SI SE ME ACABA EL TIEMPO

    }
}
