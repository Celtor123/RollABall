using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAlJuego : MonoBehaviour {

    public void reiniciar(){
      SceneManager.LoadScene("Cielo",LoadSceneMode.Single);
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Escape)){
          Application.Quit();
		}
		
	}
}
