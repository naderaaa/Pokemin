using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Board board;
    public static (Team, Team) teams = (new Team("Red"), new Team("Blue"));
    public static Team whosTurn = teams.Item1;
    public static GameObject[,] tiles = new GameObject[9, 9];


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndTurn()
    {
        // at the end of the turn, each pokemon can start moving
        foreach (GameObject tileObject in tiles)
        {
            Tile tile = tileObject.GetComponent<Tile>();
            if (tile.piece != null)
            {
                tile.piece.Steps = tile.piece.Speed;

            }
        }

        // switching whos turn it is
        if (whosTurn.Name.Equals(teams.Item1.Name))
        {
            whosTurn = teams.Item2;
        }
        else
        {
            whosTurn = teams.Item1;
        }

        Tile.ClearHighlights();
    }
}
