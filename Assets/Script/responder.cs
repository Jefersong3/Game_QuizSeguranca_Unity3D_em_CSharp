using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class responder : MonoBehaviour
{
	public AudioSource[]_audio = new AudioSource[2];

	public int idTema;

	public Text pergunta;
	public Text respostaA;
	public Text respostaB;
	public Text respostaC;
	public Text infoRespostas;

	public string[] perguntas; 			 //armazena todas as perguntas
	public string[] alternativaA;		 //armazena todas as alternativas A
	public string[] alternativaB;		 //armazena todas as alternativas B
	public string[] alternativaC;		//armazena todas as alternativas C
	public string[] corretas;			//armazena todas as alternativas corretas

	private int idPergunta;

	private float acertos;
	private float questoes;
	private float media;
	private int notaFinal;

    // Start is called before the first frame update
    void Start()
    {
		idTema = PlayerPrefs.GetInt("idTema");
		idPergunta = 0;
		questoes = perguntas.Length;

		pergunta.text = perguntas[idPergunta];
		respostaA.text = alternativaA[idPergunta];
		respostaB.text = alternativaB[idPergunta];
		respostaC.text = alternativaC[idPergunta];

		infoRespostas.text = ""+(idPergunta + 1).ToString()+ " de "+questoes.ToString()+" Questões";
	}
	
		public void resposta(string alternativa)
		{
			
			if(alternativa == "A")
			{
				if(alternativaA[idPergunta] == corretas[idPergunta])
				{
					acertos += 1;
				}

			}
			else if(alternativa == "B")
			{

				if(alternativaB[idPergunta] == corretas[idPergunta])
				{
					acertos += 1;
				}

			}
			else if(alternativa == "C")
			{

				if(alternativaC[idPergunta] == corretas[idPergunta])
				{
					acertos += 1;
				}

			}



		if(alternativa == "A")
		{
			if(alternativaA[idPergunta] == corretas[idPergunta])
			{
				_audio[0].Play();
			}

		}
		else if(alternativa == "B")
		{

			if(alternativaB[idPergunta] == corretas[idPergunta])
			{
				_audio[0].Play();
			}

		}
		else if(alternativa == "C")
		{

			if(alternativaC[idPergunta] == corretas[idPergunta])
			{
				_audio[0].Play();
			}

		}

		//apagar a partir daqui

		if(alternativa == "A")
		{
			if(alternativaA[idPergunta] != corretas[idPergunta])
			{
				_audio[1].Play();
			}

		}
		else if(alternativa == "B")
		{

			if(alternativaB[idPergunta] != corretas[idPergunta])
			{
				_audio[1].Play();
			}

		}
		else if(alternativa == "C")
		{

			if(alternativaC[idPergunta] != corretas[idPergunta])
			{
				_audio[1].Play();
			}

		}



		//apagar até aqui


			proximaPergunta();
		}
			

	void proximaPergunta()
	{
		idPergunta += 1;

		if(idPergunta <= (questoes-1))
		{

		pergunta.text = perguntas[idPergunta];
		respostaA.text = alternativaA[idPergunta];
		respostaB.text = alternativaB[idPergunta];
		respostaC.text = alternativaC[idPergunta];

		infoRespostas.text = ""+(idPergunta + 1).ToString()+ " de "+questoes.ToString()+" Questões";

		
		}
		else
		{
			media = 10 * (acertos / questoes); 		//Calcula a Media
			notaFinal = Mathf.RoundToInt(media);	//Arredonda a nota Para o proximo Inteiro

			if(notaFinal > PlayerPrefs.GetInt("notaFinal"+idTema.ToString()))
			{
				PlayerPrefs.SetInt("notaFinal"+idTema.ToString(), notaFinal);
				PlayerPrefs.SetInt("acertos"+idTema.ToString(), (int) acertos);
			}

			PlayerPrefs.SetInt("notaFinalTemp"+idTema.ToString(), notaFinal);
			PlayerPrefs.SetInt("acertosTemp"+idTema.ToString(), (int) acertos);


			Application.LoadLevel("NotaFinal");
		}

	}


    
}
