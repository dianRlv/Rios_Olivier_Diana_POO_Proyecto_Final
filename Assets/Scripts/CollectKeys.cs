using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
NOMBRE COMPLETO: Ríos Olivier Diana.
ASIGNATURA: Programación Orientada a Objetos.
NOMBRE Y NO. DE EJERCICIO: Ejercicio 5 - Variable para el item key, asi como un codigo que por medio de un evencto onTriggerEnter, destruya el
item obtenido y aparezca en el contador.
*/


/* REFERENCIAS:
El código fue modificado para su uso en este ejercicio, pero se encuentra la linea original como nota. Obtenido de un video de Youtube
donde se explica la creacion de codigo para registrar colision entre player y coins asi como su registro en la interfaz de usuario por 
medio de un GUI. 
A Webdesign || Create a Score and collectable by usign Unity 3D : https://www.youtube.com/watch?v=kqkqxfRvXck&t=552s
*/
public class CollectKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //SCRIPT APLICABLE AL ITEM KEY
    //COLISIONES
    /*En la interfaz de Unity, al objeto "Key" se le agrega el Collider que permitira su interaccion con este metodo.
    El cual permite identificar un trigger y de cierta forma colision entre el jugador y el key */
    
    //Este metodo es para la colision entre el coin y el player donde...
    private  void OnTriggerEnter(Collider other) {
        if (other.name=="Player")   //Si el objeto con el que colisiona el key tiene la etiqueta "Player"...
        {
            other.GetComponent<PlayerCollector>().key++; //Dentro del script PlayerCollector, aumenta el valor de los "keys" de uno en uno (++)
            Destroy(gameObject);    //Entonces destruye el game objecto (key)
        }
    }
}