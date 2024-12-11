using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour

{
    public GameObject WallPrefab;
    public AudioClip keySound;
    private UnityEngine.Vector3 point;

    void OnTriggerEnter(Collider other)
    {
        // pickup if it has tag "Item" and we are not carrying anything
        if (other.CompareTag("Item"))
        {
            //Destroy(GameObject.Find("Wall"));
            WallPrefab.SetActive(false);
            AudioSource.PlayClipAtPoint(keySound, point);
        }
    }

    void OnTriggerExit(Collider other)
    {
        // pickup if it has tag "Item" and we are not carrying anything
        if (other.CompareTag("Item"))
        {
            //Instantiate(GameObject.Find("Wall"));
            WallPrefab.SetActive(true);
        }
    }

}
