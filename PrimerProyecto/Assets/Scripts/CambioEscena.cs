using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour {
    public Camera mainCamera,secondCamera;
	
	public void jugar(){
     SceneManager.LoadScene("Cielo",LoadSceneMode.Single);
	}
	public void opciones(){
	 mainCamera.enabled=false;
     secondCamera.enabled=true;
	 
	}
	public void creditos(){
     SceneManager.LoadScene("Creditos",LoadSceneMode.Single);
	}
	public void salir(){
		Application.Quit();
	}
	
}
