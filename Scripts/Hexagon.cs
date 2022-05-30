using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    private Object[] materials;
    public Material highlightMaterial;
    private bool clicked = false;
    private MeshRenderer hexagonMesh;

    private Material original;
    void Start()
    {
        // set the mesh render field
        hexagonMesh = gameObject.GetComponent<MeshRenderer> ();
        RandomizeMaterial();
        original =  hexagonMesh.material;
       
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if (clicked) 
        {
            hexagonMesh.material = original;
            clicked = false;
        }
        else 
        {
            hexagonMesh.material = highlightMaterial;
            clicked = true;
        }
    }

    void RandomizeMaterial()
    {
        materials = Resources.LoadAll("TerrainMaterial", typeof(Material));
        int id = Random.Range(0, materials.Length);
        hexagonMesh.material = (Material) materials[id];
    }
}
