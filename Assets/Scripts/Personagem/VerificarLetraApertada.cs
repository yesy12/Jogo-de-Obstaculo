using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificarLetraApertada : MonoBehaviour{

    public static bool apertouA;
    public static bool apertouS;
    public static bool apertouJ;
    public static bool apertouK;
    
    void Update(){
        verificarSeApertou();
    }

    void verificarSeApertou(){
        //Letra A
        if(Input.GetKeyDown("a")){
            apertouA = true;
        }
        else if(Input.GetKeyUp("a")){
            apertouA = false;
        }

        //Letra S
        if(Input.GetKeyDown("s")){
            apertouS = true;
        }
        else if(Input.GetKeyUp("s")){
            apertouS = false;
        }

        //Letra J
        if(Input.GetKeyDown("j")){
            apertouJ = true;
        }
        else if(Input.GetKeyUp("j")){
            apertouJ = false;
        }

        //Letra K
        if(Input.GetKeyDown("k")){
            apertouK = true;
        }
        else if(Input.GetKeyUp("k")){
            apertouK = false;
        }

    }
}
