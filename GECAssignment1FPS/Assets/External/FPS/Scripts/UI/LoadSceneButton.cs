using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadSceneButton : MonoBehaviour
{
    public string sceneName = "";
    public bool setNormal = false, setHard = false;//use serparate bools because some instance wont do either (and faster than making an enum)

    private void Update()
    {
        if(EventSystem.current.currentSelectedGameObject == gameObject 
            && Input.GetButtonDown(GameConstants.k_ButtonNameSubmit))
        {
            LoadTargetScene();
        }
    }

    public void LoadTargetScene()
    {
        if (setHard)
            GameFlowManager.hardMode = true;
        if (setNormal)
            GameFlowManager.hardMode = false;
        SceneManager.LoadScene(sceneName);
    }
}
