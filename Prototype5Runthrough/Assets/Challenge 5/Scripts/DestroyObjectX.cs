/*
 * (Noah Trillizio)
 * (Assignment 8)
 * (destroys the game objects when clicked)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 2); // destroy particle after 2 seconds
    }


}
