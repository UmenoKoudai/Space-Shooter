using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Round1Timer : MonoBehaviour
{
    [SerializeField] Text _text = default;
    float _timer = default;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        float _count = 60 - _timer;
        _text.text = $"TIME : {_count.ToString("f2")}";
        if (_count <= 0)
        {
            SceneManager.LoadScene("Round2Title");
        }
    }
}
