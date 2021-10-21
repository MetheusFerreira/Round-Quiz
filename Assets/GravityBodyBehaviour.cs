using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class GravityBodyBehaviour : MonoBehaviour
{
    GravityEffectorBehaviour planet;
    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planeta").GetComponent<GravityEffectorBehaviour>();
        //GetComponent<Rigidbody2D>().useGravity = false;
        // GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        planet.Attract(transform);
    }
}
