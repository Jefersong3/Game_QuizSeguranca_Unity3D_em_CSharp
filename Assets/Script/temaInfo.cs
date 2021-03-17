using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaInfo : MonoBehaviour
{
	public int idTema;

	public GameObject estrela1;
	public GameObject estrela2;
	public GameObject estrela3;

	private int 	notaFinal;


    // Start is called before the first frame update
    void Start()
    {
		
		notaFinal = PlayerPrefs.GetInt("notaFinalTemp"+idTema.ToString());



        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
