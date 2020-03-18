using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnLetra : MonoBehaviour{
    
    // Posicao Onde o A esta na tela
    public Transform PosicaoA;
    float posicaoA_Y;
    
    //Posicao Onde o S esta na tela;
    public Transform PosicaoS;
    float posicaoS_Y;

    //Posicao Onde o J esta na tela;
    public Transform PosicaoJ;
    float posicaoJ_Y;

    //Posicao Onde o J esta na tela;
    public Transform PosicaoK;
    float posicaoK_Y;

    //Prefab da Movimentacao
    public GameObject MovimencaoA;
    public GameObject MovimencaoS;
    public GameObject MovimencaoJ;
    public GameObject MovimencaoK;


    //Hud
    public GameObject Hud;
    float hudHeight;
    float hudWidth;
    public Transform spawnX;
    float posicaoSpawn_X;

    public LetraListMoviment letraListMoviment;

    // public List<GameObject> movimentacaoList = new List<GameObject>();

    GameObject positionSpawn;
    Canvas canvas;
    CanvasScaler canvasScaler;
    GraphicRaycaster graphicRaycaster;

    //Libera Spawn das Letras

    // public bool spawn_A;
    // public bool spawn_S;
    // public bool spawn_J;
    // public bool spawn_K;

    //Contador spawnLetra_A
    public static int spawnLimite_A = 0;
    public static int spawnLetra_Atual_A = 0;
    int spawnCounterFrameCurrent_A = 0;
    public int spanwContadorFrameLimitado_A;
    public List<GameObject> movimentacaoA_Lista;


    //Contador spawnLetra_S
    public static int spawnLimite_S = 1;
    public static int spawnLetra_Atual_S = 0;
    int spawnCounterFrameCurrent_S = 0;
    public int spanwContadorFrameLimitado_S;
    public List<GameObject> movimentacaoS_Lista;

    //Contador spawnLetra_J
    public static int spawnLimite_J = 1;
    public static int spawnLetra_Atual_J = 0;
    int spawnCounterFrameCurrent_J = 0;
    public int spanwContadorFrameLimitado_J;
    public List<GameObject> movimentacaoJ_Lista;


    //Contador spawnLetra_K
    public static int spawnLimite_K = 1;
    public static int spawnLetra_Atual_K = 0;
    int spawnCounterFrameCurrent_K = 0;
    public int spanwContadorFrameLimitado_K; 

    
    public int contadorSpawn;

    void Awake(){

        positionSpawn = new GameObject();
        canvas = positionSpawn.AddComponent<Canvas>();
        canvasScaler = positionSpawn.AddComponent<CanvasScaler>();
        graphicRaycaster = positionSpawn.AddComponent<GraphicRaycaster>();

        canvas.renderMode = RenderMode.WorldSpace;
         
        canvasScaler.scaleFactor = 10.0f;
        canvasScaler.dynamicPixelsPerUnit = 10f;

        positionSpawn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 50.0f);// Altera Tamanho do Pai
        positionSpawn.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, 50.0f);// Altera Tamanho do Pai
    
        positionSpawn.name = "Position Spawn"; //Nome do Pai

        // positionSpawn.transform.parent = Hud.transform; //Torna Filho de Hud.
        positionSpawn.transform.SetParent(Hud.transform, false);
        positionSpawn.transform.localPosition = new Vector3(0f, 0f, 0f);

        posicaoA_Y = PosicaoA.transform.position.y;
        posicaoS_Y = PosicaoS.transform.position.y;
        posicaoJ_Y = PosicaoJ.transform.position.y;
        posicaoK_Y = PosicaoK.transform.position.y;


        posicaoSpawn_X = spawnX.transform.position.x/2;

        hudHeight = Hud.GetComponent<RectTransform>().rect.height/2;
        hudWidth = Hud.GetComponent<RectTransform>().rect.width/2;

        letraListMoviment = gameObject.GetComponent<LetraListMoviment>();

    }


    void Update(){
        spawnAndCounter();

    }

    void spawnAndCounter(){
        spawnCounterFrameCurrent_A += 1;
        spawnCounterFrameCurrent_S += 1;
        spawnCounterFrameCurrent_J += 1;
        spawnCounterFrameCurrent_K += 1;

        if(contadorSpawn < 500){
            if(spawnCounterFrameCurrent_A == spanwContadorFrameLimitado_A){
                if(spawnLetra_Atual_A < spawnLimite_A){
                    spawnLetra_A();
                }
                spawnCounterFrameCurrent_A = 0;
            }
        }

        if(spawnCounterFrameCurrent_S == spanwContadorFrameLimitado_S){
            if(spawnLetra_Atual_S < spawnLimite_S){
                spawnLetra_S();
            }
            spawnCounterFrameCurrent_S = 0;
        }

        // if(spawn_J == false){
        //     if(spawnCounterFrameCurrent_J == spanwContadorFrameLimitado_J){
        //         if(spawnLetra_Atual_J < spawnLimite_J){
        //             spawnLetra_J();
        //         }   
        //         spawnCounterFrameCurrent_J = 0;
        //     }
        // }

        // if(spawn_K == false){
        //     if(spawnCounterFrameCurrent_K == spanwContadorFrameLimitado_K){
        //         if(spawnLetra_Atual_K < spawnLimite_K){
        //             spawnLetra_K();
        //         }    
        //         spawnCounterFrameCurrent_K = 0;
        //     }   
        // }




    }

    void spawnLetra_A(){
        GameObject movimentacao = Instantiate(MovimencaoA);
        movimentacao.transform.SetParent(positionSpawn.transform);
        movimentacao.transform.localPosition = new Vector3(
            posicaoSpawn_X,
            -(hudHeight - posicaoA_Y),
            0f
        );
        spawnLetra_Atual_A += 1;
        contadorSpawn += 1;
        // movimentacaoA_Lista.Add(movimentacao);
        letraListMoviment.movimentacaoA_Lista.Add(movimentacao);
    }

    void spawnLetra_S(){
        GameObject movimentacao = Instantiate(MovimencaoS);
        movimentacao.transform.SetParent(positionSpawn.transform);
        movimentacao.transform.localPosition = new Vector3(
            posicaoSpawn_X,
            -(hudHeight - posicaoS_Y),
            0f
        );
        spawnLetra_Atual_S += 1;
    }

    void spawnLetra_J(){
        GameObject movimentacao = Instantiate(MovimencaoJ);
        movimentacao.transform.SetParent(positionSpawn.transform);
        movimentacao.transform.localPosition = new Vector3(
            posicaoSpawn_X,
            -(hudHeight - posicaoJ_Y),
            0f
        );
        spawnLetra_Atual_J += 1;
    }
    
    void spawnLetra_K(){
        GameObject movimentacao = Instantiate(MovimencaoK);
        movimentacao.transform.SetParent(positionSpawn.transform);
        movimentacao.transform.localPosition = new Vector3(
            posicaoSpawn_X,
            -(hudHeight - posicaoK_Y),
            0f
        );
        spawnLetra_Atual_K += 1;
    }
}
