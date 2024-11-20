using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectItems : MonoBehaviour
{
    public float speed = 10;
    public Transform carryLocation; // this is empty gameobject as a child of player, object will be carried on this position
    Transform currentItem = null;

    void Update()
    {
        // basic movement
        var x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        var y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, 0, 0);

        // press fire to drop item, if carrying something
        if (Input.GetKey(KeyCode.E))
        {
            if (currentItem != null)
            {
                // remove as child
                currentItem.parent = null;

                // release reference
                currentItem = null;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // pickup if it has tag "Item" and we are not carrying anything
        if (other.CompareTag("Item") && currentItem == null)
        {
            // take reference to that collided object
            currentItem = other.transform;

            // move it to carrying point
            currentItem.position = carryLocation.position;

            // make it as a child of player, so it moves along with player
            currentItem.parent = transform;
        }
    }
}

