using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateShower : MonoBehaviour {

    private GameObject _ShowerTrigger;
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _ShowerTrigger.SetActive(false);
        }
    }


}
