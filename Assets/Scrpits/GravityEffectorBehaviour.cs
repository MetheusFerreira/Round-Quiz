using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityEffectorBehaviour : MonoBehaviour
{
    // simulação de Faux Gravity em um objeto.
    public float gravity = -25f;
    public void Attract(Transform body) 
    {
        Vector3 targetDir = (body.position - transform.position).normalized;
        Vector3 bodyUp = body.up;

        body.rotation = Quaternion.FromToRotation(bodyUp, targetDir) * body.rotation;
        body.GetComponent<Rigidbody2D>().AddForce(targetDir * gravity);
    }
}
