         using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Temps entre la création des vaisseaux [X]
    //Ecart de création (distance) par rapport au point du spawner [X]
    //Nombre maximal d'objet à créer pour une vague [X]
    //Reference à notre vaisseau [X]

    public float tempsSpawn;
    public float distanceMax;
    public int nbMaxVaisseau;
    public GameObject vaisseau;


    void Start()
    {
        InvokeRepeating("Spawn", 1, tempsSpawn);
    }

    void Spawn()
    {
        int objetACrer = Random.Range(1, nbMaxVaisseau);

        for (int i = 0; i < objetACrer; i++)
        {
            //Je calcule la nouvelle position en X de mon futur vaisseau par rapport à mon point de spawn
            float xPos = transform.position.x + Random.Range(-distanceMax, distanceMax);

            //Je détermine la position général de mon futur vaisseau
            Vector2 nouvellePosition = transform.position; //Je stock dans une variable la position de mon point
            nouvellePosition.x = xPos; //Je dis que le X de ma variable est égal à la nouvelle position en X calculé précédement

            //On crée ici le vaisseau
            Instantiate(vaisseau, nouvellePosition, transform.rotation);
        }
    }

} 