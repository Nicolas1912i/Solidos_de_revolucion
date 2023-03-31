using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InternalSubMenuController : MonoBehaviour
{

    public RectTransform subMenuModules;
    private Vector2[] buttonsPosition;
    float finalPosition;
    bool openMenuModules = true;
    public float transitionTime = 0.5f;
    [SerializeField] GameObject[] buttons;

    void Start()
    {
        int n = SceneManager.GetActiveScene().buildIndex;
        finalPosition = Screen.width / 4.8f;
        subMenuModules.position = new Vector3(-finalPosition, subMenuModules.position.y, 0);
        buttonsConfiguration();
        //Añadir condicional para detectar seccion y determinar int activeModule para mostrar boton activo
        GameObject[] generatedButton;
        generatedButton = new GameObject[5];

        generatedButton[0] = Instantiate(buttons[0]) as GameObject;
        generatedButton[0].transform.SetParent(GameObject.Find("SubMenuModules").transform);
        generatedButton[0].GetComponent<RectTransform>().localPosition = buttonsPosition[0];

        if (n == 1 || n == 2 || n == 3)       //3D
        {
            generatedButton[1] = Instantiate(buttons[2]) as GameObject;
            generatedButton[1].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[1].GetComponent<RectTransform>().localPosition = buttonsPosition[1];
            generatedButton[2] = Instantiate(buttons[3]) as GameObject;
            generatedButton[2].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[2].GetComponent<RectTransform>().localPosition = buttonsPosition[2];
            generatedButton[3] = Instantiate(buttons[4]) as GameObject;
            generatedButton[3].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[3].GetComponent<RectTransform>().localPosition = buttonsPosition[3];

            generatedButton[4] = Instantiate(buttons[1]) as GameObject;
            generatedButton[4].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[4].GetComponent<RectTransform>().localPosition = buttonsPosition[4];
            generatedButton[4].GetComponent<Button>().interactable = false;
        }

        if (n == 6 || n == 7 || n == 8 || n == 9 || n == 10 || n == 11)     //AR
        {
            generatedButton[1] = Instantiate(buttons[1]) as GameObject;
            generatedButton[1].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[1].GetComponent<RectTransform>().localPosition = buttonsPosition[1];
            generatedButton[2] = Instantiate(buttons[3]) as GameObject;
            generatedButton[2].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[2].GetComponent<RectTransform>().localPosition = buttonsPosition[2];
            generatedButton[3] = Instantiate(buttons[4]) as GameObject;
            generatedButton[3].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[3].GetComponent<RectTransform>().localPosition = buttonsPosition[3];

            generatedButton[4] = Instantiate(buttons[2]) as GameObject;
            generatedButton[4].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[4].GetComponent<RectTransform>().localPosition = buttonsPosition[4];
            generatedButton[4].GetComponent<Button>().interactable = false;
        }

        if (n == 4 || n == 5)       //Documentation
        {
            generatedButton[1] = Instantiate(buttons[2]) as GameObject;
            generatedButton[1].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[1].GetComponent<RectTransform>().localPosition = buttonsPosition[1];
            generatedButton[2] = Instantiate(buttons[1]) as GameObject;
            generatedButton[2].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[2].GetComponent<RectTransform>().localPosition = buttonsPosition[2];
            generatedButton[3] = Instantiate(buttons[4]) as GameObject;
            generatedButton[3].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[3].GetComponent<RectTransform>().localPosition = buttonsPosition[3];

            generatedButton[4] = Instantiate(buttons[3]) as GameObject;
            generatedButton[4].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[4].GetComponent<RectTransform>().localPosition = buttonsPosition[4];
            generatedButton[4].GetComponent<Button>().interactable = false;
        }

        if (n == 12 || n == 13 || n == 14 || n == 15 || n == 16 || n == 17 || n == 18 || n == 19 || n == 20 || n == 21 || n == 22 || n == 23 || n == 24 || n == 25)      //Video
        {
            generatedButton[1] = Instantiate(buttons[2]) as GameObject;
            generatedButton[1].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[1].GetComponent<RectTransform>().localPosition = buttonsPosition[1];
            generatedButton[2] = Instantiate(buttons[3]) as GameObject;
            generatedButton[2].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[2].GetComponent<RectTransform>().localPosition = buttonsPosition[2];
            generatedButton[3] = Instantiate(buttons[1]) as GameObject;
            generatedButton[3].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[3].GetComponent<RectTransform>().localPosition = buttonsPosition[3];

            generatedButton[4] = Instantiate(buttons[4]) as GameObject;
            generatedButton[4].transform.SetParent(GameObject.Find("SubMenuModules").transform);
            generatedButton[4].GetComponent<RectTransform>().localPosition = buttonsPosition[4];
            generatedButton[4].GetComponent<Button>().interactable = false;
        }
    }

    void buttonsConfiguration()
    {
        buttonsPosition = new Vector2[5];
        buttonsPosition[0] = new Vector2(-74.55629f, 205.8432f); //HomeButton
        buttonsPosition[1] = new Vector2(70.9f, 205.8432f); // On right next to the HomeButton
        buttonsPosition[2] = new Vector2(-74.55629f, 58.99989f); //Below HomeButton
        buttonsPosition[3] = new Vector2(70.89999f, 58.99989f); //Below the button next on right to the HomeButton
        buttonsPosition[4] = new Vector2(1, -181); // Active Scene
    }

    IEnumerator MoveTransition(float time, Vector3 startPosition, Vector3 endPosition)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            subMenuModules.position = Vector3.Lerp(startPosition, endPosition, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subMenuModules.position = endPosition;
    }

    void StartMoveMenuTransition(float time, Vector3 startPosition, Vector3 endPosition)
    {
        StartCoroutine(MoveTransition(time, startPosition, endPosition));
    }

    public void CallStart()
    {
        int direction = 1;
        if (!openMenuModules) direction = -1;

        StartMoveMenuTransition(transitionTime, subMenuModules.position, new Vector3(direction * finalPosition, subMenuModules.position.y, 0));
        openMenuModules = !openMenuModules;
    }
}
