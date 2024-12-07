using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place4 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Placeobject;
    public GameObject finishobject;
    public GameObject nextobject;
    public GameObject currentUI;
    public GameObject nextUI;
    void Start()
    {
        finishobject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "place4")
        {
            Destroy(gameObject);
            finishobject.SetActive(true);
            nextobject.SetActive(true);
            currentUI.SetActive(false);
            nextUI.SetActive(true);

        }
    }
}
