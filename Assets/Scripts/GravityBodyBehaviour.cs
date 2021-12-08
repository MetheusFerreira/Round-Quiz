using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody2D))]
public class GravityBodyBehaviour : MonoBehaviour
{
    // faz com que um corpo seja capaz de ser puxado para um objeto categorizado como planeta.
    GravityEffectorBehaviour planet;
    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planeta").GetComponent<GravityEffectorBehaviour>();
    }

    void FixedUpdate()
    {
        planet.Attract(transform);
    }
}
