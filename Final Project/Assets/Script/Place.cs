using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Placeobject;
    public GameObject finishobject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OntriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "place")
        {
            Destroy(Placeobject);
            finishobject.SetActive(true);

        }
    }
}
