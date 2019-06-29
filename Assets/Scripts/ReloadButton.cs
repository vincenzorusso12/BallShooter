using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadButton : MonoBehaviour
{
    public GUIStyle stileBottoni;
    private string scena = "Game";
    private string testo = "Ricomincia partita";

    /*mettere la scena game e la scena menu nelle build settings se no NON FUNZIONA*/

    /*Per mettere lo SFONDO ai bottoni devo mettere un immagine jpeg*/

    /*Per Attivare lo script metterlo nella camera*/
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(Screen.width -200, 100, 100, 100));
        if (GUILayout.Button(testo, stileBottoni)) { SceneManager.LoadScene(scena); }
        GUILayout.EndArea();


    }
}
