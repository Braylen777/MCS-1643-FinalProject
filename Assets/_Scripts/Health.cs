using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HP = 3;
    public GameObject KeyO;
    public GameObject KeyT;

    void OnTriggerEnter(Collider other)
    {
        //if player is touched by obstacle take damage
        if (other.gameObject.CompareTag("Obstacle"))
        {
            HP--;

        }

        if (HP <= 0)
        {
            gameObject.transform.position = new UnityEngine.Vector3(-.17f, .25f, -2.18f);
            HP += 3;
            KeyO.transform.position = new UnityEngine.Vector3(-4f, 3.05f, -4f);
            KeyT.transform.position = new UnityEngine.Vector3(4.05f, .57f, 17f);
        }

    }











}
