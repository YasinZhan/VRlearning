using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfirstscript : MonoBehaviour
{
    public Color origincolor; 
    public MeshRenderer component;
    // Start is called before the first frame update
    void Start()
    {
        component = GetComponent<MeshRenderer>();
        origincolor = component.material.color;
        print("start");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        component.material.color = Color.blue;
    }
    private void OnMouseExit()
    {
        component.material.color = origincolor;
    }
}
