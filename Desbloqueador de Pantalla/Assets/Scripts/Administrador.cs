using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 

public class Administrador : MonoBehaviour
{
    public Preguntas preguntas;

    public Text pregunta;
    
    public Button opcionA;
    public Text opcionAText; 

    public Button opcionB;
    public Text opcionBText; 
    
    public Button opcionC;
    public Text opcionCText; 

    public Button opcionD;
    public Text opcionDText; 

    public Button opcionE;
    public Text opcionEText;

    public string opcionCorrecta;

    public GameObject felicitaciones;
    public GameObject losiento;
    public GameObject canvasPreguntas; 

    public void Start()
    {
        SeleccionarPregunta();

        // ASEGURAN QUE LOS CANVAS DE RESULTADOS COMIENCEN APAGADOS: 
        felicitaciones.SetActive(false);
        losiento.SetActive(false);
    }


    public void Tests()
    {
        Debug.Log("El Boton ha sido presionado"); 
    }

    public void SeleccionarPregunta()
    {
        int max = preguntas.preguntasFormato1.Count;
        int i = Random.Range(0, max);

        pregunta.text = preguntas.preguntasFormato1[i].pregunta;

        opcionAText.text = preguntas.preguntasFormato1[i].opcionA;

        opcionBText.text = preguntas.preguntasFormato1[i].opcionB;

        opcionCText.text = preguntas.preguntasFormato1[i].opcionC;

        opcionDText.text = preguntas.preguntasFormato1[i].opcionD;

        opcionEText.text = preguntas.preguntasFormato1[i].opcionE;

        opcionCorrecta = preguntas.preguntasFormato1[i].opcionCorrecta; 
    }


    public void OpcionA()
    {
        if (opcionCorrecta == "A")
        {
            RespondeCorrectamente(); 
        }

        else
        {
            RespondeErroneamente(); 
        }
    }


    public void OpcionB()
    {
        if (opcionCorrecta == "B")
        {
            RespondeCorrectamente();
        }

        else
        {
            RespondeErroneamente();
        }
    }


    public void OpcionC()
    {
        if (opcionCorrecta == "C")
        {
            RespondeCorrectamente();
        }

        else
        {
            RespondeErroneamente();
        }
    }

    public void OpcionD()
    {
        if (opcionCorrecta == "D")
        {
            RespondeCorrectamente();
        }

        else
        {
            RespondeErroneamente();
        }
    }

    public void OpcionE()
    {
        if (opcionCorrecta == "E")
        {
            RespondeCorrectamente();
        }

        else
        {
            RespondeErroneamente();
        }
    }





    public void RespondeCorrectamente()
    {
        canvasPreguntas.SetActive(false);
        felicitaciones.SetActive(true);
        losiento.SetActive(false); 
    }


    public void RespondeErroneamente()
    {
        canvasPreguntas.SetActive(false);
        felicitaciones.SetActive(false);
        losiento.SetActive(true); 

    }

    public void SalirAJugar()
    {
        Application.Quit(); 
    }

    public void VolverAIntentarlo()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);

        
    }
}
