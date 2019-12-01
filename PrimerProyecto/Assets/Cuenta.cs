using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuenta : MonoBehaviour {
	public Text contador;
    public float numero = 10f;
	// Use this for initialization
	void Start () {
		contador.text = " " + numero;
	}
	
	// Update is called once per frame
	void Update () {
	if(numero>0){
	numero -= Time.deltaTime;
    contador.text = " " + numero.ToString("f0");
	}
	else
	{
		 contador.text = "Tiempo";
	}
	
	}
}
