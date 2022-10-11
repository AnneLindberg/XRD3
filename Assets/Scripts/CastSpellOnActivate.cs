using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class CastSpellOnActivate : MonoBehaviour
{
    public GameObject spell;
    public Transform spawnPoint;
    public float spellSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(CastSpell);  
    }

    public void CastSpell(ActivateEventArgs arg)
    {
        GameObject spawnedSpell = Instantiate(spell);
        spawnedSpell.transform.position = spawnPoint.position;
        spawnedSpell.GetComponent<Rigidbody>().velocity = spawnPoint.forward * spellSpeed;
        Destroy(spawnedSpell, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
