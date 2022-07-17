using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private int _level = 1;
    [SerializeField]
    private GameObject _platformPrefab;
    [SerializeField]
    private GameObject _redPlatformPrefab;
    [SerializeField]
    private GameObject _greenPlatformPrefab;
    private int _y;
    // Start is called before the first frame update
    void Start()
    {
        InstantiatePlatforms();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void InstantiatePlatforms()
    {
        InstantiationPart1();
        InstantiationPart2();
    }
    private void InstantiationPart1()
    {
        for (int y = 2; y < 40 * _level; y += 8)
        {
            for (int x = -36; x < 36; x += 8)
            {
                int randomNum = Random.Range(0, 2);
                if (randomNum == 1)
                {
                    GameObject newPlatform = Instantiate(_platformPrefab, new Vector3(x, y, 0), Quaternion.identity);
                    if (y == 2)
                    {
                        newPlatform.tag = "Layer 1";
                    }
                    else if(y == 6)
                    {
                        newPlatform.tag = "Layer 2";
                    }
                    else if (y == 10)
                    {
                        newPlatform.tag = "Layer 3";
                    }
                    else if (y == 14)
                    {
                        newPlatform.tag = "Layer 4";
                    }
                    else if (y == 18)
                    {
                        newPlatform.tag = "Layer 5";
                    }
                    else if (y == 22)
                    {
                        newPlatform.tag = "Layer 6";
                    }
                    else if (y == 26)
                    {
                        newPlatform.tag = "Layer 7";
                    }
                    else if (y == 30)
                    {
                        newPlatform.tag = "Layer 8";
                    }
                    else if (y == 34)
                    {
                        newPlatform.tag = "Layer 9";
                    }
                    else if (y == 38)
                    {
                        newPlatform.tag = "Layer 10";
                    }

                    FallingPlatforms _newPlatform = newPlatform.GetComponent<FallingPlatforms>();

                }
                else if (randomNum == 0)
                {
                    GameObject newRedPlatform = Instantiate(_redPlatformPrefab, new Vector3(x, y, 0), Quaternion.identity);
                    if (y == 2)
                    {
                        newRedPlatform.tag = "Layer 1";
                    }
                    else if (y == 6)
                    {
                        newRedPlatform.tag = "Layer 2";
                    }
                    else if (y == 10)
                    {
                        newRedPlatform.tag = "Layer 3";
                    }
                    else if (y == 14)
                    {
                        newRedPlatform.tag = "Layer 4";
                    }
                    else if (y == 18)
                    {
                        newRedPlatform.tag = "Layer 5";
                    }
                    else if (y == 22)
                    {
                        newRedPlatform.tag = "Layer 6";
                    }
                    else if (y == 26)
                    {
                        newRedPlatform.tag = "Layer 7";
                    }
                    else if (y == 30)
                    {
                        newRedPlatform.tag = "Layer 8";
                    }
                    else if (y == 34)
                    {
                        newRedPlatform.tag = "Layer 9";
                    }
                    else if (y == 38)
                    {
                        newRedPlatform.tag = "Layer 10";
                    }
                    FallingPlatforms _newRedPlatform = newRedPlatform.GetComponent<FallingPlatforms>();
                    _newRedPlatform.isOscillating();
                }
            }
        }
    }
    private void InstantiationPart2()
    {
        for (int y = 6; y < 46 * _level; y += 8)
        {
            for (int x = -32; x < 32; x += 8)
            {
                int randomNum = Random.Range(0, 2);
                if (randomNum == 1)
                {
                    GameObject newPlatform = Instantiate(_platformPrefab, new Vector3(x, y, 0), Quaternion.identity);
                    if (y == 2)
                    {
                        newPlatform.tag = "Layer 1";
                    }
                    else if (y == 6)
                    {
                        newPlatform.tag = "Layer 2";
                    }
                    else if (y == 10)
                    {
                        newPlatform.tag = "Layer 3";
                    }
                    else if (y == 14)
                    {
                        newPlatform.tag = "Layer 4";
                    }
                    else if (y == 18)
                    {
                        newPlatform.tag = "Layer 5";
                    }
                    else if (y == 22)
                    {
                        newPlatform.tag = "Layer 6";
                    }
                    else if (y == 26)
                    {
                        newPlatform.tag = "Layer 7";
                    }
                    else if (y == 30)
                    {
                        newPlatform.tag = "Layer 8";
                    }
                    else if (y == 34)
                    {
                        newPlatform.tag = "Layer 9";
                    }
                    else if (y == 38)
                    {
                        newPlatform.tag = "Layer 10";
                    }
                    FallingPlatforms _newPlatform = newPlatform.GetComponent<FallingPlatforms>();

                }
                else if (randomNum == 0)
                {
                    GameObject newRedPlatform = Instantiate(_redPlatformPrefab, new Vector3(x, y, 0), Quaternion.identity);
                    if (y == 2)
                    {
                        newRedPlatform.tag = "Layer 1";
                    }
                    else if (y == 6)
                    {
                        newRedPlatform.tag = "Layer 2";
                    }
                    else if (y == 10)
                    {
                        newRedPlatform.tag = "Layer 3";
                    }
                    else if (y == 14)
                    {
                        newRedPlatform.tag = "Layer 4";
                    }
                    else if (y == 18)
                    {
                        newRedPlatform.tag = "Layer 5";
                    }
                    else if (y == 22)
                    {
                        newRedPlatform.tag = "Layer 6";
                    }
                    else if (y == 26)
                    {
                        newRedPlatform.tag = "Layer 7";
                    }
                    else if (y == 30)
                    {
                        newRedPlatform.tag = "Layer 8";
                    }
                    else if (y == 34)
                    {
                        newRedPlatform.tag = "Layer 9";
                    }
                    else if (y == 38)
                    {
                        newRedPlatform.tag = "Layer 10";
                    }
                    FallingPlatforms _newRedPlatform = newRedPlatform.GetComponent<FallingPlatforms>();
                    _newRedPlatform.isOscillating();
                }
            }
            _y = y + 4;
        }
        GameObject greenPlatform = Instantiate(_greenPlatformPrefab, new Vector3(0, _y, 0), Quaternion.identity);
        FallingPlatforms _greenPlatform = greenPlatform.GetComponent<FallingPlatforms>();
        _greenPlatform.isGreen();
        
    }



    public void touchedGreen()
    {
        _level++;
        SceneManager.LoadScene("Level 1");
    }
}
