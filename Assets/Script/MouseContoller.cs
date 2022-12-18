using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseContoller : MonoBehaviour
{
    public bool particleBool, handleBool;
    public ParticleSystem particle;
    RaycastHit hit;


    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            particleBool = true;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                particle.transform.position = hit.point;
            }

        }
        else
        {
            particleBool = false;
            handleBool = false;

        }

        if (particleBool && !handleBool)
        {
            handleBool = true;
            particle.Play();
        }

        if (!particleBool)
        {
            particle.Stop();
        }
    }
}
