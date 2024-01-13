using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Classe - faz um agrupamento de variáveis e métodos
public class Player : MonoBehaviour
{
    // Variável - um objeto na memória capaz de armazenar dados de diversos tipos
    // int - numeros inteiros;
    // float - numeros numeros decimais, encerra com f para entender que é float;
    // bool - booleana;
    // string - texto entre " "
    // GameObject chao; armazenar objeto pelo gameobject
    // Transform - armazenar com o transform.

    public int health;
    public float speed;

    // Métodos - são blocos de instruções de código - juntas desempenham uma mecânica
    // void - declaração de método - void não precisa retornar nada

    void Attack( )
    {
        // código para atacar
    }

    void Movement( )
    {
        // codigo para mover
    }

    void Jump( )
    {
        // codigo para pular
    }

    // Start is called before the first frame update - Chamado ao inicializar o Jogo
    /*  void Start( )
     {
     }

     // Update is called once per frame - Chamado a cada frame -  Em média 60freimes por segundo.
     void Update( )
     {
     } */
}
