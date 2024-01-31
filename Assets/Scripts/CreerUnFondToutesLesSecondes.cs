using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreerUnFondToutesLesSecondes : MonoBehaviour
{
    public GameObject fond;
    public float tempsApparitionFond;
    
    void Start()
    {
        Invoke("CreerFond", tempsApparitionFond);
    }

    void CreerFond()
    {
        //Faire une variable pour décaler
        Vector3 decalage = new Vector3(0, 19, 0);
        Instantiate(fond, transform.position + decalage, transform.rotation);
    }
}
