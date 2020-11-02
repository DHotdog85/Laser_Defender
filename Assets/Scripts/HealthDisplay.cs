using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private Text playerHealthText;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthText = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthText.text = player.GetHealth().ToString();
    }
}
