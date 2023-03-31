using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlaceStages : MonoBehaviour
{
    [SerializeField] GameObject objeto;
    MeshRenderer rend;

    [Header("Objetos emergentes")]
    [SerializeField] GameObject Arandelas;
    [SerializeField] GameObject Planos;
    [SerializeField] GameObject Ejes;
    [SerializeField] GameObject Malla;


    void Start(){
        rend = objeto.gameObject.GetComponent<MeshRenderer>();
    }

    public void Gotcha(){
        Arandelas.SetActive(true);
        Planos.SetActive(true);
        Ejes.SetActive(true);
        Malla.SetActive(true);
    }

    public void OhShit(){
        Arandelas.SetActive(false);
        Planos.SetActive(false);
        Ejes.SetActive(false);
        Malla.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (rend.enabled == true){
            Gotcha();
        } else
        {
            OhShit();
        }
    }
}
