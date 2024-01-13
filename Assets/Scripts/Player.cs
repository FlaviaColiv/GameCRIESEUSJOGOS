using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Classe - faz um agrupamento de vari�veis e m�todos
public class Player : MonoBehaviour
{
    // Vari�vel - um objeto na mem�ria capaz de armazenar dados de diversos tipos
    // int - numeros inteiros;
    // float - numeros numeros decimais, encerra com f para entender que � float;
    // bool - booleana;
    // string - texto entre " "
    // GameObject chao; armazenar objeto pelo gameobject
    // Transform - armazenar com o transform.

    public int health;
    public float speed;

    // M�todos - s�o blocos de instru��es de c�digo - juntas desempenham uma mec�nica
    // void - declara��o de m�todo - void n�o precisa retornar nada

    void Attack( )
    {
        // c�digo para atacar
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

     // Update is called once per frame - Chamado a cada frame -  Em m�dia 60freimes por segundo.
     void Update( )
     {
     } */
}
