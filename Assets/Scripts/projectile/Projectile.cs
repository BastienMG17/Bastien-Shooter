using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{


    public Vector2 direction;

    public float vitesse;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*vitesse*Time.deltaTime); 
    }
}
