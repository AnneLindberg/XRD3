using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace Unity.Template.VR
{
    
public class CastWingardium : MonoBehaviour
{
    public const double z = 25.49074;
    public const double y = 0.136;
    public const double x = 24.33683;


    private bool wingardiumActivate = false;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(CastWingGardium);
    }

    public void CastWingGardium(ActivateEventArgs arg)
    {
        var spell = GameObject.Find("Bottle2");
        if (!wingardiumActivate)
        {
            spell.transform.position = new Vector3((float)x, (float)y, (float)z);
            wingardiumActivate = !wingardiumActivate;
        }
        else
        {
            spell.transform.position = new Vector3((float)x, (float)y + (float)2.5 ,(float)z);
            wingardiumActivate = !wingardiumActivate;
        }
    }
}
}