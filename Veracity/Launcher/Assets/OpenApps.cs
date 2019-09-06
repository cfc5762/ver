using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class OpenApps : MonoBehaviour {
    public static bool RecRoom;
    public static bool Youtube;
    public static bool Job;
    public static bool Fun;
    public static bool Audio;
    public static bool Nature;
    public static bool ABC;
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
        else if (name == "Audio")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Audioshield\\Audioshield.exe");
        }
        else if (name == "Job")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Job Simulator\\JobSimulator.exe");
        }
        else if (name == "Fun")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\NVIDIA VR Funhouse\\VRFunhouse.exe");
        }
        else if (name == "Nature")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\Nature Treks VR\\Nature Treks VR.exe");
        }
        else if (name == "ABCPaint")
        {
            Process.Start("C:\\Program Files (x86)\\Steam\\steamapps\\common\\ABC Paint\\ABCPaint.exe");
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
        else if (name == "Job")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("JobSimulator"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                //dont do that
            }
        }
        else if (name == "Nature")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Nature Treks VR"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                //dont do that
            }
        }
        else if (name == "ABCPaint")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("ABCPaint"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                //dont do that
            }
        }
        else if (name == "Audio")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("Audiosheild"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                //dont do that
            }
        }
        else if (name == "Fun")
        {
            try
            {
                foreach (Process proc in Process.GetProcessesByName("VRFunhouse"))
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
        if (Input.GetKeyDown("r")||RecRoom)
        {
            if (Process.GetProcessesByName("Recroom_Release").Length > 0)
            {
                RecRoom = false;
                Close("RecRoom");
            }
            else
            {
                RecRoom = false;
                Open("RecRoom");
            }
        }
        if (Input.GetKeyDown("y")||Youtube)
        {
            if (Process.GetProcessesByName("YouTubeVR").Length > 0)
            {
                Youtube = false;
                Close("Youtube");
            }
            else
            {
                Youtube = false;
                Open("Youtube");
            }
        }
        if (Input.GetKeyDown("n")||Nature)
        {
            if (Process.GetProcessesByName("Nature Treks VR").Length > 0)
            {
                Nature = false;
                Close("Nature");
            }
            else
            {
                Nature = false;
                Open("Nature");
            }
        }
        if (Input.GetKeyDown("f")||Fun)
        {
            if (Process.GetProcessesByName("VRFunhouse").Length > 0)
            {
                Fun = false;
                Close("Fun");
            }
            else
            {
                Fun = false;
                Open("Fun");
            }
        }
        if (Input.GetKeyDown("p")||ABC)
        {
            if (Process.GetProcessesByName("ABCPaint").Length > 0)
            {
                ABC = false;
                Close("ABCPaint");
            }
            else
            {
                ABC = false;
                Open("ABCPaint");
            }
        }
        if (Input.GetKeyDown("a")||Audio)
        {
            if (Process.GetProcessesByName("Audiosheild").Length > 0)
            {
                Audio = false;
                Close("Audio");
            }
            else
            {
                Audio = false;
                Open("Audio");
            }
        }
        if (Input.GetKeyDown("j")||Job)
        {
            if (Process.GetProcessesByName("JobSimulator").Length > 0)
            {
                Job = false;
                Close("Job");
            }
            else
            {
                Job = false;
                Open("Job");
            }
        }
    }
}
