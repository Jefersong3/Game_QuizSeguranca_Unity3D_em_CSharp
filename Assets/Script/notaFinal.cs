using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour
{
	private int idTema;

	public Text txtNota;
	public Text txtInfoTema;

	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela3;

	private int scoreFinal;
	private int acertos;


    // Start is called before the first frame update
    void Start()
    {
		idTema = PlayerPrefs.GetInt("idTema");

		estrela1.SetActive(false);
		estrela2.SetActive(false);
		estrela3.SetActive(false);


		scoreFinal = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());
		acertos = PlayerPrefs.GetInt("acertosTemp"+idTema.ToString());

		txtNota.text = scoreFinal.ToString();
		txtInfoTema.text = "Voce Acertou "+acertos.ToString()+" de 10 Questões";

		if(scoreFinal == 10)
		{
			estrela1.SetActive(true);
			estrela2.SetActive(true);
			estrela3.SetActive(true);
		}
		else if(scoreFinal >= 7)
		{
			estrela1.SetActive(true);
			estrela2.SetActive(true);
			estrela3.SetActive(false);
		}
		else if(scoreFinal >= 5)
		{
			estrela1.SetActive(true);
			estrela2.SetActive(false);
			estrela3.SetActive(false);
		}

		//Apagar a Partir desse Ponto

		if(scoreFinal == 10)
		{
			GetComponent<AudioSource>().Play();
		}
	 	//Apagar Até esse Ponto


    }

	public void jogarNovamente()
	{
		Application.LoadLevel("T"+idTema.ToString());
	}

   
}
