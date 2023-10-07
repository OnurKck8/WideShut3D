using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWave : MonoBehaviour
{
   
    public Material[] SelectedColors,WallColor;
    public Material[] colorFirst;
    MeshRenderer other,otherbox,otherwall;
    public float scalespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(scalespeed, scalespeed, scalespeed) * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.tag == "Door")
        {
             other =collision.gameObject.GetComponent<MeshRenderer>();
            other.materials = SelectedColors;
            StartCoroutine(wait());

        }
        if (collision.gameObject.tag == "Boxe")
        {
            otherbox = collision.gameObject.GetComponent<MeshRenderer>();
            otherbox.materials = SelectedColors;
            StartCoroutine(waittwo());

        }
        
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);

        other.materials = colorFirst;

    }
   IEnumerator waittwo()
    {
        yield return new WaitForSeconds(0.5f);

        otherbox.materials = colorFirst;
    }
    

}

