using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class OpenApps : MonoBehaviour {
    Process current;
    public void Open(string name)
    {
        if (name == "RecRoom")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\RecRoom\\Recroom_Release.exe");
        }
        else if (name == "Youtube")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\YouTubeVR\\YouTubeVR.exe");
        }
    }
    public void Close(string name)
    {
        if (name == "RecRoom")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Recroom_Release"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                //dont do that
            }
        }
        else if (name == "Youtube")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("YouTubeVR"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                //dont do that
            }
        }
    }
	// Use this for initialization
	void Start () {
       
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("r"))
        {
            if (Process.GetProcessesByName("Recroom_Release").Length > 0)
                Close("RecRoom");
            else
            {
                Open("RecRoom");
            }
        }
        if (Input.GetKeyDown("y"))
        {
            if (Process.GetProcessesByName("YouTubeVR").Length > 0)
                Close("Youtube");
            else
            {
                Open("Youtube");
            }
        }
	}
}
