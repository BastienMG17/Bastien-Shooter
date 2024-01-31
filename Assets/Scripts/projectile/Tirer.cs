using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tirer : MonoBehaviour
{
    // Update is called once per frame
    public GameObject projectile;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
        Instantiate(projectile, transform.position,transform.rotation);
            GetComponent<AudioSource>().pitch = Random.Range(0.2f, 2f);
        GetComponent<AudioSource>().Play();
        }
    }
}
