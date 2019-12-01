using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movemento : MonoBehaviour { 
    public float velocidad;
    private Rigidbody rb;
    private int count;
    public Text contador;
    public Text ganador;
    private GameObject objeto;
    public Text r;
    public float infiltrado;
    public Text fin;

    private void Start()
    {
        objeto = GameObject.Find("Canvas/CuentaAtrás");
        rb = GetComponent<Rigidbody>();
        count = 0;
        setcontador();
        ganador.text = "";
    }
    void FixedUpdate()
    {
        float movhorizontal=Input.GetAxis("Horizontal");
        float movvertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movhorizontal,0.0f,movvertical);
        rb.AddForce(movimiento *velocidad);
    }
    void Update() {
        final();
        contar();        
    }
    void OnTriggerEnter(Collider colision)
    {
     if(colision.gameObject.CompareTag("Pick_UP"))
        {
            colision.gameObject.SetActive(false);
            count = count+1;
            setcontador();
        } 
     if(colision.gameObject.CompareTag("Respawn")){ 
         if(count<8){    
         ganador.text="UUUPS";  
         fallo();  
         }     
     }
    }
    void setcontador()
    {
        contador.text = "Contando " + count.ToString();
        if(count >= 8)
        {
            ganador.text = "Ganaste, EN_HORA_BUENA";
            fin.text="Teclee la tecla espacio para reiniciar";
            
        }
    }
    void fallo(){        
        SceneManager.LoadScene("Fin",LoadSceneMode.Single);
    }
    void final(){
      if(Input.GetKey("space") && count==8){
             SceneManager.LoadScene("Cielo",LoadSceneMode.Single);
         }
    }
    void contar(){
        r=objeto.GetComponent<Text>();
        string a = r.text;
        infiltrado= float.Parse(a);
        if(infiltrado<= 0 && count<8){
           fallo();
        }
        
    }
    
}
