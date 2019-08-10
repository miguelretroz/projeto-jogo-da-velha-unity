using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {
    public Text casa1;
    public Text casa2;
    public Text casa3;
    public Text casa4;
    public Text casa5;
    public Text casa6;
    public Text casa7;
    public Text casa8;
    public Text casa9;
    public Text casa1Ex;
    public Text casa2Ex;
    public Text casa3Ex;
    public Text casa4Ex;
    public Text casa5Ex;
    public Text casa6Ex;
    public Text casa7Ex;
    public Text casa8Ex;
    public Text casa9Ex;
    public string[,] tabuleiro = new string[3, 3];
    public bool jogador;
    public Text vez;
    public bool vitoriaJogador1;
    public bool vitoriaJogador2;
    public GameObject painelGame;
    public GameObject painelVitoria;
    public GameObject painelPause;
    public Text ganhador;
    public int vezesJogadas;
    public KeyCode pause;
    public GameObject indicadorH;
    public GameObject indicadorH1;
    public GameObject indicadorH2;
    public GameObject indicadorV;
    public GameObject indicadorV1;
    public GameObject indicadorV2;
    public GameObject indicadorD;
    public GameObject indicadorD1;


    // Use this for initialization
    void Start() {
        tabuleiro[0, 0] = "";
        tabuleiro[0, 1] = "";
        tabuleiro[0, 2] = "";
        tabuleiro[1, 0] = "";
        tabuleiro[1, 1] = "";
        tabuleiro[1, 2] = "";
        tabuleiro[2, 0] = "";
        tabuleiro[2, 1] = "";
        tabuleiro[2, 2] = "";
        jogador = true;
        vezesJogadas = 0;

    }

    // Update is called once per frame
    public void clickCasa1() {
        if (jogador & tabuleiro[0, 0] == "") {
            tabuleiro[0, 0] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[0, 0] == "") {
            tabuleiro[0, 0] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa2() {
        if (jogador & tabuleiro[0, 1] == "") {
            tabuleiro[0, 1] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[0, 1] == "") {
            tabuleiro[0, 1] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa3() {
        if (jogador & tabuleiro[0, 2] == "") {
            tabuleiro[0, 2] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[0, 2] == "") {
            tabuleiro[0, 2] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa4() {
        if (jogador & tabuleiro[1, 0] == "") {
            tabuleiro[1, 0] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[1, 0] == "") {
            tabuleiro[1, 0] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa5() {
        if (jogador & tabuleiro[1, 1] == "") {
            tabuleiro[1, 1] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[1, 1] == "") {
            tabuleiro[1, 1] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa6() {
        if (jogador & tabuleiro[1, 2] == "") {
            tabuleiro[1, 2] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[1, 2] == "") {
            tabuleiro[1, 2] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa7() {
        if (jogador & tabuleiro[2, 0] == "") {
            tabuleiro[2, 0] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[2, 0] == "") {
            tabuleiro[2, 0] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa8() {
        if (jogador & tabuleiro[2, 1] == "") {
            tabuleiro[2, 1] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[2, 1] == "") {
            tabuleiro[2, 1] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickCasa9() {
        if (jogador & tabuleiro[2, 2] == "") {
            tabuleiro[2, 2] = "X";
            jogador = false;
            vezesJogadas++;
        }
        else if (jogador == false & tabuleiro[2, 2] == "") {
            tabuleiro[2, 2] = "O";
            jogador = true;
            vezesJogadas++;
        }
    }
    public void clickReinicio() {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
        painelPause.SetActive(false);
    }
    public void clickSair() {
        Application.Quit();
    }
    public void clickVoltar() {
        painelPause.SetActive(false);
    }
    public void clickMenu() {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    void Update() {
        casa1.text = tabuleiro[0, 0];
        casa2.text = tabuleiro[0, 1];
        casa3.text = tabuleiro[0, 2];
        casa4.text = tabuleiro[1, 0];
        casa5.text = tabuleiro[1, 1];
        casa6.text = tabuleiro[1, 2];
        casa7.text = tabuleiro[2, 0];
        casa8.text = tabuleiro[2, 1];
        casa9.text = tabuleiro[2, 2];
        casa1Ex.text = tabuleiro[0, 0];
        casa2Ex.text = tabuleiro[0, 1];
        casa3Ex.text = tabuleiro[0, 2];
        casa4Ex.text = tabuleiro[1, 0];
        casa5Ex.text = tabuleiro[1, 1];
        casa6Ex.text = tabuleiro[1, 2];
        casa7Ex.text = tabuleiro[2, 0];
        casa8Ex.text = tabuleiro[2, 1];
        casa9Ex.text = tabuleiro[2, 2];
        if (jogador) {
            vez.text = "VEZ DO JOGADOR 1 !";
        }
        else {
            vez.text = "VEZ DO JOGADOR 2 !";
        }
        if (tabuleiro[0, 0] == "X" & tabuleiro[0, 1] == "X" & tabuleiro[0, 2] == "X") {
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            painelVitoria.SetActive(true);
            indicadorH.SetActive(true);
        }
        else if (tabuleiro[1, 0] == "X" & tabuleiro[1, 1] == "X" & tabuleiro[1, 2] == "X") {
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            painelVitoria.SetActive(true);
            indicadorH1.SetActive(true);
        }
        else if (tabuleiro[2, 0] == "X" & tabuleiro[2, 1] == "X" & tabuleiro[2, 2] == "X") {
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            painelVitoria.SetActive(true);
            indicadorH2.SetActive(true);
        }
        //Comparação se o jogador 1 ganhou vertical

        else if (tabuleiro[0, 0] == "X" & tabuleiro[1, 0] == "X" & tabuleiro[2, 0] == "X") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            indicadorV.SetActive(true);
        }
        else if (tabuleiro[0, 1] == "X" & tabuleiro[1, 1] == "X" & tabuleiro[2, 1] == "X") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            indicadorV1.SetActive(true);
        }
        else if (tabuleiro[0, 2] == "X" & tabuleiro[1, 2] == "X" & tabuleiro[2, 2] == "X") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            indicadorV2.SetActive(true);
        }

        //Comparação se o jogador 1 ganhou diagonal

        else if (tabuleiro[0, 0] == "X" & tabuleiro[1, 1] == "X" & tabuleiro[2, 2] == "X") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            indicadorD.SetActive(true);
        }
        else if (tabuleiro[2, 0] == "X" & tabuleiro[1, 1] == "X" & tabuleiro[0, 2] == "X") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 1 GANHOU!!!";
            indicadorD1.SetActive(true);
        }

        //Comparações do jogador 2
        else if (tabuleiro[0, 0] == "O" & tabuleiro[0, 1] == "O" & tabuleiro[0, 2] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text = "JOGADOR 2 GANHOU!!!";
            indicadorH.SetActive(true);
        }

        else if (tabuleiro[1, 0] == "O" & tabuleiro[1, 1] == "O" & tabuleiro[1, 2] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorH1.SetActive(true);
        }
        else if (tabuleiro[2, 0] == "O" & tabuleiro[2, 1] == "O" & tabuleiro[2, 2] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorH2.SetActive(true);
        }
        //Comparação se o jogador 2 ganhou vertical

        else if (tabuleiro[0, 0] == "O" & tabuleiro[1, 0] == "O" & tabuleiro[2, 0] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorV.SetActive(true);
        }
        else if (tabuleiro[0, 1] == "O" & tabuleiro[1, 1] == "O" & tabuleiro[2, 1] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorV1.SetActive(true);
        }
        else if (tabuleiro[0, 2] == "O" & tabuleiro[1, 2] == "O" & tabuleiro[2, 2] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorV2.SetActive(true);
        }

        //Comparação se o jogador 2 ganhou diagonal

        else if (tabuleiro[0, 0] == "O" & tabuleiro[1, 1] == "O" & tabuleiro[2, 2] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorD.SetActive(true);
        }
        else if (tabuleiro[2, 0] == "O" & tabuleiro[1, 1] == "O" & tabuleiro[0, 2] == "O") {
            painelVitoria.SetActive(true);
            ganhador.text ="JOGADOR 2 GANHOU!!!";
            indicadorD1.SetActive(true);
        }
        else if (vezesJogadas == 9) {
            painelVitoria.SetActive(true);
            ganhador.text = "DEU VELHA!!!";
            indicadorH.SetActive(true);
            indicadorH1.SetActive(true);
            indicadorH2.SetActive(true);
            indicadorV.SetActive(true);
            indicadorV1.SetActive(true);
            indicadorV2.SetActive(true);
            indicadorD.SetActive(true);
            indicadorD1.SetActive(true);
        }
        if (Input.GetKeyDown(pause)) {
            if (painelPause.activeSelf) {
                painelPause.SetActive(false);
            }
            else {
                painelPause.SetActive(true);
            }
        }

    }

}
