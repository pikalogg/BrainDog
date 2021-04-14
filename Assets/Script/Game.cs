using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Player player;
    public List<Monster> monsters;
    public Light[] coins;

    void Init()
    {

    }

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            Application.Quit();
            return;
        }
    }


    public void LoadLevel01() => LoadLevel(1);

    public void LoadLevel02() => LoadLevel(2);

    public void LoadLevel03() => LoadLevel(3);

    private void LoadLevel(int level)
    {
        Debug.Log("reset");
        switch (level)
        {
            case 1:
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel("GamePlay");
#pragma warning restore CS0618 // Type or member is obsolete
                break;
            default:
                break;
        }
        
    }

#pragma warning disable CS0618 // Type or member is obsolete
    public void BackToGameMenu() => Application.LoadLevel("GameMenu");
#pragma warning restore CS0618 // Type or member is obsolete


#pragma warning disable CS0618 // Type or member is obsolete
    public void BackToLevelMenu() => Application.LoadLevel("LevelMenu");
#pragma warning restore CS0618 // Type or member is obsolete

    public void ExitClickButton() => Application.Quit(); 

}
