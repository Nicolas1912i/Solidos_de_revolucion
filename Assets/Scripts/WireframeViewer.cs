using UnityEngine;
using UnityEngine.UI;

public class WireframeViewer : MonoBehaviour
{

    public Shader wires;
    private Shader standar;
    Renderer rend;
    public bool active = true;
    public GameObject buttonSI;
    public GameObject buttonNO;

    void Start()
    {
        rend = GetComponent<Renderer>();
        standar = rend.material.shader;
        Desactivando();
        active = true;
    }

    public void OnEnable(){
        active = true;
        rend.material.shader = wires;
    }

    public void OnDisable(){
        active = false;
        rend.material.shader = standar;
    }

    public void Activando(){
        buttonSI.SetActive(false);
        buttonNO.SetActive(true);
    }

    public void Desactivando(){
        buttonSI.SetActive(true);
        buttonNO.SetActive(false);
    }

}
