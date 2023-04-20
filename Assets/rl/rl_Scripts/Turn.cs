using UnityEngine.UI;
using UnityEngine;

using UnityEngine.SceneManagement; //Unity4.6֮��İ汾ע��Ҫ�����



public class Turn : MonoBehaviour
{
    public void Click_turn()
    {

        //Application.LoadLevel(SceneNumber); //Unity4.6��֮ǰ�汾��д��

        SceneManager.LoadScene("Gallery/DEMO");

    }

}