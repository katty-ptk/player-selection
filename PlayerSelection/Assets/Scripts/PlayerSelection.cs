using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour
{
    [SerializeField] private Button FemalePlayer;
    [SerializeField] private Button MalePlayer;
    [SerializeField] private Button ZombiePlayer;

    public void SelectPlayer() {
        Debug.Log("player selected!");
    }
}
