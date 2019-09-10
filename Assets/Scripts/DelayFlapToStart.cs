using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayFlapToStart : MonoBehaviour {
    public GameObject flapToRestar;
    public float delay=1f;
	// Use this for initialization
	void OnEnable() {
		Invoke("EnableFlapToRestar",delay);
	}
	void EnableFlapToRestar(){
      flapToRestar.SetActive(true);  
    }
}
