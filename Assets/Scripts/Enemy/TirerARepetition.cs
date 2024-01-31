using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirerARepetition : MonoBehaviour
{
    public GameObject projectile;
    public float cadanceTir = 2f;

    void Start()
    {
        InvokeRepeating("Tirer", Random.Range(2f, 7f), cadanceTir);
    }

    void Tirer()
    {
        GameObject monProjectile = Instantiate(projectile, transform.position, Quaternion.identity);
        monProjectile.transform.localEulerAngles = new Vector3(0, 0, 180); //Permet de faire regarder le projectile vers le bas (on lui fait faire une raotation de 180 degres)
    }
}
