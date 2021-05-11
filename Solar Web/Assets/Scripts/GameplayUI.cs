using TMPro;
using UnityEngine;

public class GameplayUI : MonoBehaviour
{
    //  TODO:
    /* settings,
     * backpack,
     * minimap
     * health
     * bullet count
     */

    public GameObject settingMenu;
    public TextMeshProUGUI backpackSpace;
    public TextMeshProUGUI bulletCount;
    public RectTransform healthImage;

    private int maxAmmo = 12;
    private int maxBackpackSpace = 5;

    //  DEBUGGING
    private float size = 100;
    private int bckpck = 5;
    private int bltcnt = 12;

    private void Start()
    {
        settingMenu.SetActive(false);
        BulletCount(bltcnt);
        BackpackCount(bckpck);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            settingMenu.SetActive(true);
        }

        //  DEBUGGING
        size -= (size - Time.deltaTime) * 0.001F;
        Health((int)size);

        if (Input.GetKeyUp(KeyCode.U))
        {
            bltcnt--;
            BulletCount(bltcnt);
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            bckpck--;
            BackpackCount(bckpck);
        }
    }

    //  Settings
    public void ResumeGame()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        settingMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //  Bullet UI

    // All logic checks should be performed before calling this function.
    public void BulletCount(int ammo)
    {
        bulletCount.text = ammo.ToString() + " / " + maxAmmo.ToString();
    }

    //  Backpack UI

    // All logic checks should be performed before calling this function.
    public void BackpackCount(int space)
    {
        backpackSpace.text = space.ToString() + " / " + maxBackpackSpace.ToString();
    }

    //  Health UI
    //  Health value between 100 and 0;
    public void Health(int health)
    {
        float size = (305 / 100) * health;
        healthImage.offsetMax = new Vector2(-305 + size, healthImage.offsetMin.x);
    }
}