using UnityEngine;
using System.IO;
using System.Collections;

public class Read : MonoBehaviour {

    // Use this for initialization
    public Transform TileA;
    public Transform TileB;

    void Start () {
        StreamReader stream = new StreamReader("Assets/Maps/testmap.txt");
        int y = 0;
        while (!stream.EndOfStream)
        {
            string line = stream.ReadLine();
            int x = 0;
            foreach (char c in line)
            {
                if (c == 'A')
                {
                    print("x: " + x + " y: " + y);
                    Instantiate(TileA, new Vector2(x * 0.6403f, y * 0.641f), Quaternion.identity);
                }
                else if (c == 'B')
                {
                    print("x: " + x + " y: " + y);
                    Instantiate(TileB, new Vector2(x * 0.6403f, y * 0.641f), Quaternion.identity);
                }
                x++;
            }
            y++;
        }
        stream.Close();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
