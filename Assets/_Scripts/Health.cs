using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HP = 3;
    public GameObject KeyO;
    public GameObject KeyT;
    public AudioClip hurtSound;
    private UnityEngine.Vector3 point;
    void OnTriggerEnter(Collider other)
    {
        //if player is touched by obstacle take damage
        if (other.gameObject.CompareTag("Obstacle"))
        {
            HP--;
            AudioSource.PlayClipAtPoint(hurtSound, point);
        }

        if (HP == 3)
        {
            //Debug.Log("made player pink");
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }

        if (HP == 2)
        {
            //Debug.Log("made player grey");
            gameObject.GetComponent<Renderer>().material.color = Color.grey;
        }

        if (HP == 1)
        {
            //Debug.Log("made player white");
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }

        if (HP <= 0)
        {
            gameObject.transform.position = new UnityEngine.Vector3(-.17f, .25f, -2.18f);
            HP += 3;
            KeyO.transform.position = new UnityEngine.Vector3(-4f, 3.05f, -4f);
            KeyT.transform.position = new UnityEngine.Vector3(-4.00f, .57f, 17f);
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        }

    }











}
