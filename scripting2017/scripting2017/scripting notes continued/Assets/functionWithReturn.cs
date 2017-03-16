using UnityEngine;
using System.Collections;

public class functionWithReturn : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject firstPlayer;

    public string[] deepThoughts;
    public int i = 0;

    GameObject ChooseFirstPlayer()
    {
        int ranNum = Random.Range(1, 3);

        switch (ranNum)
        {
            case 1:
                return player1;
            case 2:
                return player2;
            default:
                return player3;
        }
    }

    private string Messages()
    {
        if (i >= deepThoughts.Length)
        {
            i = 0;
        }
        return(deepThoughts[i++]);

    }
    public void onButtonClick()
    {
        print(Messages());
    }
    void Start()
    {
        firstPlayer = ChooseFirstPlayer();
    }
}