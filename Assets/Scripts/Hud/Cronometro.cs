using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour{

    public int timeFrameQuantidade;
    public int timeFrameAtual;
    public static int segundos;
    public static int minutos;
    [SerializeField] Text CronometroText;
    
    void Update(){
        somarFrameAtual();
        somarSegundos();
        somarMinutos();
        atualizarCronometro();
    }

    void somarFrameAtual(){
        timeFrameAtual += 1;
    }

    void somarSegundos(){
        if(timeFrameAtual == timeFrameQuantidade){
            timeFrameAtual = 0;
            segundos += 1;
        }
    }

    void somarMinutos(){
        if(segundos == 60){
            segundos = 0;
            minutos += 1;
        }
    }

    void atualizarCronometro(){
        var tempo = "";
        if(minutos < 10){
            tempo = "0" + minutos.ToString() + ":";
        }
        else{
            tempo = minutos.ToString() + ":";
        }
        if(segundos < 10){
            tempo += "0" + segundos.ToString();
        }
        else {
            tempo += segundos.ToString();
        }
        CronometroText.text =  tempo;
    }
}
