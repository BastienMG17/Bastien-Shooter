using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireEnnemis : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Détruire le vaisseau du joueur
            Destroy(collision.gameObject);



        }
    }
}
