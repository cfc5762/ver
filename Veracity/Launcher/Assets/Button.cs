using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public int buttonnum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (buttonnum)
            {
                case 0:
                    OpenApps.Audio = true;
                    break;
                case 1:
                    OpenApps.Youtube = true;
                    break;
                case 2:
                    OpenApps.Job = true;
                    break;
                case 3:
                    OpenApps.Fun = true;
                    break;
                case 4:
                    OpenApps.Nature = true;
                    break;
                case 5:
                    OpenApps.ABC = true;
                    break;
                default:
                    break;
            }
        }
    }
}
