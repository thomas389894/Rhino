using UnityEngine;

public class FadeScene : MonoBehaviour
{
    public Animator animartor;

    public void FadePlayGame()
    {
        FadeToLevel(1);
    }
    public void FadeToMenu(int levelIndex)
    {
        animartor.SetTrigger("FadeOut");
    }
    public void FadeToLevel(int levelIndex)
    {
        animartor.SetTrigger("FadeOut");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
