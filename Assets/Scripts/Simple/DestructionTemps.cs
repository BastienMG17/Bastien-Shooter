using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionTemps : MonoBehaviour
{
    public float temps;

    void Start()
    {
        Destroy(gameObject, temps);  
    }

    
}
