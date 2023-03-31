//
// Fingers Gestures
// (c) 2015 Digital Ruby, LLC
// http://www.digitalruby.com
// Source code may be used for personal or commercial projects.
// Source code may NOT be redistributed or sold.
// 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalRubyShared
{
	public class DemoScript3DOrbit : MonoBehaviour
	{
        private WireframeViewer wireframe;
        private FingersPanOrbitComponentScript orbit;

        private void Start()
        {
            orbit = GetComponent<FingersPanOrbitComponentScript>();
            orbit.OrbitTargetTapped += Orbit_OrbitTargetTapped;
            wireframe = FindObjectOfType<WireframeViewer>().GetComponent<WireframeViewer>();
        }

        // Modified for allow an Raycast and be able to use a canvas independiently of the funcionality of the script
        private void Orbit_OrbitTargetTapped()
        {
            StartCoroutine(RaycastThis());
        }

        IEnumerator RaycastThis()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);

            if (hit.transform.gameObject.tag == "Object")
            {
                WireframeViewer viewer = hit.transform.gameObject.GetComponent<WireframeViewer>();
                if (viewer.active)
                {
                    viewer.OnDisable();
                }
                else
                {
                    viewer.OnEnable();
                }
            }
            yield return null;
        }
    }
}
