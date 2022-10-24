using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class CastLumosSpell : MonoBehaviour
{
    
    private bool lumosActive = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(CastLumos);
    }

    public void CastLumos(ActivateEventArgs arg)
    {
        var spell = GameObject.Find("SpellStart");
        if (!lumosActive)
        {
            spell.GetComponent<Light>().intensity = 0f;
            lumosActive = !lumosActive;
        }
        else
        {
            spell.GetComponent<Light>().intensity = 3.67f;
            lumosActive = !lumosActive;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}