using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
    // Update is called once per frame
    void Update()
    {
        if (_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out var hit)) return;
        {
            Console.WriteLine("HER");
            var selection = hit.transform;
            if (!selection.CompareTag(selectableTag)) return;
            var selectionRenderer = selection.GetComponent<Renderer>();
            
            if (selectionRenderer != null)
            {
                selectionRenderer.material = highlightMaterial;
            }

            _selection = selection;
        }
    }
}
