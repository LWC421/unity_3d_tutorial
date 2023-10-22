using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer meshRenderer;

    private void Start()
    {
         meshRenderer = GetComponent<MeshRenderer>();
    }

    // 물체가 부딪힐때 발생한다
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            meshRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
