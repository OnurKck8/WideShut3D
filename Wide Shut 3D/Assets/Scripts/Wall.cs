using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public Material[] SelectedColors;
    public Material[] colorFirst;
    MeshRenderer wall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Circle")
        {
         wall=gameObject.GetComponent<MeshRenderer>();
            wall.materials = SelectedColors;
            StartCoroutine(wallclor());
        }
    }
    IEnumerator wallclor()
    {
        yield return new WaitForSeconds(0.8f);
        wall.materials = colorFirst;
    }
}
