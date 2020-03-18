using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraTrigger : MonoBehaviour{

    public bool entrouNaLetra = false;
    public float positionA_X ;
    public float positionS_X ;
    public float positionJ_X ;
    public float positionK_X ;

    void OnTriggerEnter(Collider other){
        var select = other.tag;

        if(select == "a_posicao" || select == "s_posicao" || select == "j_posicao" || select == "k_posicao"){
            entrouNaLetra = true;
            ContadorLetraTrigger.contador += 1;
        }
    }

    void OnTriggerExit(Collider other){
        var select = other.tag;

        if(select == "a_posicao" || select == "s_posicao" || select == "j_posicao" || select == "k_posicao"){
            entrouNaLetra = false;
        }
    }

}
