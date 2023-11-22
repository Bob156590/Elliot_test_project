using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathScreen : MonoBehaviour
{
    public TMP_Text gameOver;
    private string[] deathLevel = {
        "Subjet brainwaves have ceased\nSubject did not last long.",
        "AAAAAAAAAAAAAAAAAA"
    };
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void LvlUp(int xp)
    {
        gameObject.SetActive(true);
        if(xp < 1000) gameOver.text = "You Died\n"+ deathLevel[Random.Range(0, 1)];
    }
}
