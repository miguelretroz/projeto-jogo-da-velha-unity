using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject painelCreditos;
    public GameObject painelMenu;
    public KeyCode voltar;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(voltar)) {
            if (painelCreditos) {
                painelCreditos.SetActive(false);
                painelMenu.SetActive(true);
            }
        }
	}
    public void clickJogar() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
    public void clickSair() {
        Application.Quit();
    }
    public void clickCreditos() {
        painelCreditos.SetActive(true);
        painelMenu.SetActive(false);
    }
    public void clickVoltar() {
        painelCreditos.SetActive(false);
        painelMenu.SetActive(true);
    }
}
