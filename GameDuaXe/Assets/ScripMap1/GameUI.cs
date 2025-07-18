using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    private void Update()
    {
        HienThiThoiGian();
    }
    public void HienThiThoiGian()
    {
        timeText.SetText(Mathf.FloorToInt(Thoigiangame.Instance.ThoigianChoPhep).ToString()); 
    }
    public void ChoiLai()
    {
        SceneManager.LoadScene("map1");
    }
    public void VeMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
