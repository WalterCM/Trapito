using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class Read : MonoBehaviour {

    // Use this for initialization
    public Transform TileA;
    public Transform TileB;

    void Start () {
        Dictionary<char, Transform> Tiles = new Dictionary<char, Transform>();
        Tiles.Add('A', TileA);
        Tiles.Add('B', TileB);
  
        StreamReader stream = new StreamReader("Assets/Maps/testmap.txt");
        int y = 0;
        while (!stream.EndOfStream)
        {
            string line = stream.ReadLine();
            int x = -line.Length / 2;
            foreach (char c in line)
            {
                Instantiate(Tiles[c], new Vector2(x * 0.6403f, y * 0.641f), Quaternion.identity);
                x++;
            }
            y--;
        }
        stream.Close();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
