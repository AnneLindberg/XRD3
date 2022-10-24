using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireSpell : MonoBehaviour
{

    private Animator animator;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("spell"))
        {
            Debug.Log("Hit Arissa");
            animator.SetBool("isHit",true);
            Explosion();

        }
    }

    private void Explosion()
    {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;
        Instantiate(explosion, pos, rot);
        
    }
}
