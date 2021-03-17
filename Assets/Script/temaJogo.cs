using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class temaJogo : MonoBehaviour
{
	public Button 		btnPlay;
	public Text 		txtNomeTema;

	public GameObject 	infoTema;
	public GameObject	estrela1;
	public GameObject	estrela2;
	public GameObject	estrela3;

	public string[]		nomeTema;
	public int 			numeroQuestoes;

	private int 		idTema;


    // Start is called before the first frame update
    void Start()
    {
		idTema = 0;
		txtNomeTema.text = nomeTema[idTema];

		btnPlay.interactable = false;
    }

	public void selecioneTema(int i)
	{
		idTema = i;
		PlayerPrefs.SetInt("idTema", idTema);
		txtNomeTema.text = nomeTema[idTema];

		int notaFinal = PlayerPrefs.GetInt("notaFinal"+idTema.ToString());
		int acertos = PlayerPrefs.GetInt("acertos"+idTema.ToString());




		btnPlay.interactable = true;


	}

	public void jogar()
	{
		Application.LoadLevel("T"+idTema.ToString());



	}




}
