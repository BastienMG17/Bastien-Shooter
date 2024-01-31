using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debug_ApprenonsLeCode : MonoBehaviour
{

    //Objectif : Essayez de comprendre comment est-ce que ce code fonctionne
    //Indice --> Debug.Log() est une fonction qui affiche un texte dans la console d'Unity
    //N'hésitez pas à tester et a appuyer sur play dans Unity ;)

    //Petit exercice, je veux que le script :
    //1 - Affiche quelque chose uniqement quand on reste appuyé sur la touche "J" (à l'aide de la fonction prévu à cet effet)
    //2 - Il est OBLIGATOIRE d'utiliser la même variable que vous appelerez "fraise" pour écrire quelque chose dans la console
    //3 - Affiche dans un premier temps "Comment allez vous ?""
    //4 - Affiche dans un second temps "Je vais super bien !"

    string banane = "Hello World !";
    string Fraise = "Comment allez vous ?";

    void Start()
    {
        Debug.Log(banane);

        Debug.Log("banane");

        banane = "Are you ready to code ?!";
        Debug.Log(banane);
    }

    void Update()
    {
        Debug.Log("Echo !");

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Coucou");
        }

        if (Input.GetKey(KeyCode.J))
        {
            Debug.Log(Fraise);
            Fraise = "Je vais super bien !";
                Debug.Log(Fraise);
        }
    }

    void OnApplicationQuit()
    {
        Debug.Log("Avez vous compris comment le code fonctionne ;) ?");
    }


   
    
    
   }