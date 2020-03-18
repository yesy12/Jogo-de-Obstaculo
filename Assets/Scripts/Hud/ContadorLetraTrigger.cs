using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorLetraTrigger : MonoBehaviour{
    
    public static int contador;
    public Text contadorText;

    void Start(){
        
    }


    void Update(){
        contadorText.text = contador.ToString() + " vezes";
    }
}
