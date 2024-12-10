using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour

{
    public GameObject WallPrefab;
    void OnTriggerEnter(Collider other)
    {
        // pickup if it has tag "Item" and we are not carrying anything
        if (other.CompareTag("Item"))
        {
            //Destroy(GameObject.Find("Wall"));
            WallPrefab.SetActive(false);
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
