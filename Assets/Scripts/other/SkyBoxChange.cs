﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxChange : MonoBehaviour
{

    public Material firstMat;
    public Material secondMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("SwitchMaterial", 1f);
    }

    void SwitchMaterial()
    {
        RenderSettings.skybox = secondMat;
    }
}
