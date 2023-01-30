using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuthUIManager : MonoBehaviour
{
    public static AuthUIManager instance;

    public GameObject loginUI;
    public GameObject registerUI;

    private void Awake()
    {
	    if (instance == null)
	    {
		    instance = this;
	    }
	    else if (instance != null)
	    {
		    Debug.Log("Instance already exist, destroying object!");
		    Destroy(this);
	    }
    }

    public void LoginScreen()
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }

    public void RegisterScreen()
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }
}
