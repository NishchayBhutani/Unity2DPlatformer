using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PurchaseScript : MonoBehaviour
{

    private CapsuleCollider2D capsuleCollider;
    

    void Awake() {
        capsuleCollider = transform.GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider) {
        string collidedObject = collider.gameObject.name;
        if(collidedObject == "Player") {
            Debug.Log("Player entered the shop");
        }
    }
}
