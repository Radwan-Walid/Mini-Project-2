using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject homeCamera;
    public GameObject homePage;

    public GameObject creditsCamera;
    public GameObject creditsPage;

    public void StartGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void Credits() {
        creditsCamera.SetActive(true);
        homeCamera.SetActive(false);

        creditsPage.SetActive(true);
        homePage.SetActive(false);
    }

    public void BackFromCredits() {
        creditsCamera.SetActive(false);
        homeCamera.SetActive(true);

        creditsPage.SetActive(false);
        homePage.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
    }
}
