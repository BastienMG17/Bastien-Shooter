using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouclier : MonoBehaviour
{

    bool BouclierActive = false;
    bool enCoursdeRechargement = false;

    float tempsBouclier = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActiverBouclier();

            Invoke("DesactiverBouclier", tempsBouclier);

        }


    }

    void ActiverBouclier()
    {
        BouclierActive = true;
        enCoursdeRechargement = true;


    }
    
    void DesactiverBouclier()
    {
        BouclierActive = false;
        enCoursdeRechargement = false;


    }

    void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.tag == "Enemy")
        {
            if(BouclierActive == true)
            {
                Destroy(colision.gameObject);

            }
            else
            {
                Destroy(gameObject);

            }
        
        
        
        
        }
    }


}
