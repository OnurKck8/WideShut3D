using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public Animator door;
    public GameObject nextPanel;
    public FirstPersonController first;
    public GameObject chapter;
    void Start()
    {
        
        PlayerPrefs.SetInt("saved", int.Parse(SceneManager.GetActiveScene().name));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshCollider>().isTrigger = false;
            door.SetBool("open", true);
            first.enabled = false;
            chapter.SetActive(false);
            StartCoroutine(wait());

        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.1f);
        nextPanel.SetActive(true);

    }
}
