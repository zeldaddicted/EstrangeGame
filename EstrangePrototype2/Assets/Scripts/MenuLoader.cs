using UnityEngine;
using System.Collections;

public class MenuLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnPlayClick()
    {
        Application.LoadLevel("main");
    }

    public void OnQuitClick()
    {
        Application.Quit();
    }
}
