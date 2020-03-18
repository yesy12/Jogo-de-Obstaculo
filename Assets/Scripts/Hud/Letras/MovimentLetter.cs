using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentLetter : MonoBehaviour{

    int speedMovimentLetter;

    // Posicao Onde o A esta na tela
    public float posicaoA_X;
    
    //Posicao Onde o S esta na tela;
    public float posicaoS_X;

    //Posicao Onde o J esta na tela;
    public float posicaoJ_X;

    //Posicao Onde o J esta na tela;
    public float posicaoK_X;

    public float posicaoLetra_X;

    void Awake(){
        setSpeedMoviment(58);
        //veloc 2000, spawn 500, passaram 498 = 99,6%. Time.deltaTime
        //veloc 2000, spawn 10, passaram  0 = 0%.
        //veloc 200, spawn 100, passaram  0 = 0%.
        //veloc 50, spawn 100, passaram  0 = 0%.

        var posicao_a = GameObject.FindWithTag("a_posicao");
        posicaoA_X = posicao_a.transform.position.x;

        var posicao_s = GameObject.FindWithTag("s_posicao");
        posicaoS_X = posicao_s.transform.position.x;

        var posicao_j = GameObject.FindWithTag("j_posicao");
        posicaoJ_X = posicao_j.transform.position.x;

        var posicao_k = GameObject.FindWithTag("k_posicao");
        posicaoK_X = posicao_k.transform.position.x;

    }


    void Update(){
        posicaoLetra_X = transform.position.x;
        run();
    }

    void setSpeedMoviment(int velocity){
        speedMovimentLetter = velocity;
    }

    void run(){
        transform.position += new Vector3(-speedMovimentLetter, 0f, 0f);



    }

}
