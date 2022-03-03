using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{

    public SpriteRenderer sr;
    public List<Sprite> players = new List<Sprite>();
    private int selectedPlayer = 0;
    public GameObject playerSkin;

    public void PreviousOption() {
        selectedPlayer -= 1;

        if ( selectedPlayer < 0 ) {
            selectedPlayer = players.Count - 1;
        }

        sr.sprite = players[selectedPlayer];
    }
    public void NextOption() {
        selectedPlayer += 1;

        if ( selectedPlayer == players.Count ) {
            selectedPlayer = 0;
        }

        sr.sprite = players[selectedPlayer];
    }

    public void PlayGame() {
        PrefabUtility.SaveAsPrefabAsset( playerSkin, "Assets/Prefabs/selectedPlayer.prefab" );
        SceneManager.LoadScene("MainGame");
    }

}
