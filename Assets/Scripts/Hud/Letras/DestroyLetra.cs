using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLetra : MonoBehaviour{

    LetraTrigger letraTrigger;
    bool letraTrigger_entrouNaLetra;
    
    //MovimentLetter
    MovimentLetter movimentLetter;
    float posicaoA_X;
    float posicaoS_X;
    float posicaoJ_X;
    float posicaoK_X;
    float posicaoLetra_X;

    string tag;
    void Start(){
        letraTrigger = gameObject.GetComponent<LetraTrigger>();
        movimentLetter = gameObject.GetComponent<MovimentLetter>();
        posicaoA_X = movimentLetter.posicaoA_X;
        posicaoS_X = movimentLetter.posicaoS_X;
        posicaoJ_X = movimentLetter.posicaoJ_X;
        posicaoK_X = movimentLetter.posicaoK_X;
        tag = transform.gameObject.tag;
    } 

    void Update(){
        posicaoLetra_X = transform.position.x;
        getInfoByLetraTrigger();
        deleteOnPositionScreen();
        deleteOnTriggerAndInputGetKeyDown();
    }

    void getInfoByLetraTrigger(){
        letraTrigger_entrouNaLetra = letraTrigger.entrouNaLetra;
    }

    void deleteOnPositionScreen(){
        if(posicaoA_X > (posicaoLetra_X + 30)){
            if(tag == "a_modelo"){
                SpawnLetra.spawnLetra_Atual_A -= 1;
            }
            else if(tag == "s_modelo"){
                SpawnLetra.spawnLetra_Atual_S -= 1;
            }
            else if(tag == "j_modelo"){
                SpawnLetra.spawnLetra_Atual_J -= 1;
            }
            else if(tag == "k_modelo"){
                SpawnLetra.spawnLetra_Atual_K -= 1;
            }
            movementPlayer.point = 1;
            Destroy(this.gameObject);
        }
    }

    void deleteOnTriggerAndInputGetKeyDown(){
        if(letraTrigger_entrouNaLetra == true){

            var letra_A = VerificarLetraApertada.apertouA;
            var letra_S = VerificarLetraApertada.apertouS;
            var letra_J = VerificarLetraApertada.apertouJ;
            var letra_K = VerificarLetraApertada.apertouK;

            if(letra_A == true){
                SpawnLetra.spawnLetra_Atual_A -= 1;
                if(movementPlayer.point < 10){
                    movementPlayer.point += 1;
                }
                Destroy(this.gameObject);
            } 
            else if(letra_S == true){
                SpawnLetra.spawnLetra_Atual_S -= 1;
                if(movementPlayer.point < 10){
                    movementPlayer.point += 1;
                }
                Destroy(this.gameObject);
            } 
            else if(letra_J == true){
                SpawnLetra.spawnLetra_Atual_J -= 1;
                if(movementPlayer.point < 10){
                    movementPlayer.point += 1;
                }
                Destroy(this.gameObject);
            }
            else if(letra_K == true){
                SpawnLetra.spawnLetra_Atual_K -= 1;
                if(movementPlayer.point < 10){
                    movementPlayer.point += 1;
                }
                Destroy(this.gameObject);
            }                            
            
        }//if(letraTrigger_entrouNaLetra == true){

    } //   void deleteOnTriggerAndInputGetKeyDown(){


}
