using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float directionX = 0;

        if (Input.GetKey(KeyCode.RightArrow)) //Pour appuyer sur la touche de droite
        {
            directionX = 0.1f;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) //Pour appuyer sur la touche de gauche
        {
            directionX = -0.1f;
        }

        Vector2 directionFinale = new Vector2(directionX, 0);
        transform.Translate(directionFinale);

    }
}