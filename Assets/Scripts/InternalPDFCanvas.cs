using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InternalPDFCanvas : MonoBehaviour
{

    public RectTransform subPDFModules;
    float finalPosition;
    bool openPDFModules = true;
    public float transitionTime = 0.5f;

    void Start()
    {
        int n = SceneManager.GetActiveScene().buildIndex;
        finalPosition = Screen.width / 4.8f;
        subPDFModules.position = new Vector3(-finalPosition, subPDFModules.position.y, 0);
    }

    IEnumerator MoveTransition(float time, Vector3 startPosition, Vector3 endPosition)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            subPDFModules.position = Vector3.Lerp(startPosition, endPosition, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        subPDFModules.position = endPosition;
    }

    void StartMoveMenuTransition(float time, Vector3 startPosition, Vector3 endPosition)
    {
        StartCoroutine(MoveTransition(time, startPosition, endPosition));
    }

    public void CallStart()
    {
        int direction = 1;
        if (!openPDFModules) direction = -1;

        StartMoveMenuTransition(transitionTime, subPDFModules.position, new Vector3(direction * finalPosition, subPDFModules.position.y, 0));
        openPDFModules = !openPDFModules;
    }
}
