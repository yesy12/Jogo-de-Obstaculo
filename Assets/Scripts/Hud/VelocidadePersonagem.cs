using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VelocidadePersonagem : MonoBehaviour{

    public Text velocidadeText;
    public static string texto;

    void Update(){
        velocidadeText.text = texto;
    }

}
