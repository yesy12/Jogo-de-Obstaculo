﻿using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectManager : MonoBehaviour{

    [SerializeField] Material materialMuda;

    // Update is called once per frame
    void Update(){ 
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit)){
            var selection = hit.transform;
            var selectionRenderer = selection.GetComponent<Renderer>();
            if(selectionRenderer != null){
                // selectionRenderer.material = materialMuda;
                print(selectionRenderer.gameObject.tag);
            }
        }
    }
}
