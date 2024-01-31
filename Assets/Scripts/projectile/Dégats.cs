using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dégats : MonoBehaviour
{
    public GameObject Explosion;
    
    void OnTriggerEnter2D(Collider2D collision)
  {
        if(collision.tag == "Enemy")
        {

            Destroy(collision.gameObject);
            
            Instantiate(Explosion, transform.position, transform.rotation);

            FindObjectOfType<Score>().score += 100;
            
            Destroy(gameObject);
        }
        
  }
        

}
