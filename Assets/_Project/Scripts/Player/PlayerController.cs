using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject selectedTower; // Tower selected to place
    [SerializeField] private GameObject selectedTowerUIObject;
    [SerializeField] private GameObject[] towers;
    [SerializeField] private Sprite noTowerSprite; // TODO: Move this somewhere where it makes more sense

    private void Start()
    {
        UpdateSelectionUI();
    }

    private void OnEnable()
    {
        
        InputReader.controls.Base.Pause.performed += PauseTest;
        InputReader.controls.Base.SelectTower.performed += SelectTower;

        InputReader.controls.Placement.PlaceTower.performed += ctx => PlaceTower(ctx, Mouse.current.position.ReadValue());
        InputReader.controls.Placement.Cancel.performed += CancelTowerPlacement;
    }

    //private void Click(Vector2 mousePos)
    //{
    //    Debug.Log("Clicked! Position: " + mousePos);
    //    Debug.Log("WorldPos of mouse: " + mainCamera.ScreenToWorldPoint(mousePos));
    //}

    private void PlaceTower(InputAction.CallbackContext ctx, Vector2 screenPosition)
    {
        if (MoneyManager.instance.GetBalance() - selectedTower.GetComponent<TowerBase>().GetCost() >= 0)
        {
            GameObject newTower = Instantiate(selectedTower);
            Vector3 towerPosition = mainCamera.ScreenToWorldPoint(screenPosition);

            newTower.transform.position = new Vector3(towerPosition.x, towerPosition.y, 0);
            MoneyManager.instance.RemoveMoney(newTower.GetComponent<TowerBase>().GetCost());
        } else
        {
            Debug.Log("ur poor lol");
        }

        InputReader.ToggleActionMap(InputReader.controls.Base);
        selectedTower = null;
        UpdateSelectionUI();
    }

    private void PauseTest(InputAction.CallbackContext ctx)
    {
        Debug.Log("Paused!");
    }

    private void SelectTower(InputAction.CallbackContext ctx)
    {
        switch (ctx.control.name)
        {
            case "1":
                selectedTower = towers[0];
                break;
            case "2":
                selectedTower = towers[1];
                break;
        }

        InputReader.ToggleActionMap(InputReader.controls.Placement);
        UpdateSelectionUI();
    }

    private void CancelTowerPlacement(InputAction.CallbackContext ctx)
    {
        InputReader.ToggleActionMap(InputReader.controls.Base);
        selectedTower = null;
        UpdateSelectionUI();
    }

    private void UpdateSelectionUI()
    {
        if (selectedTower != null)
        {
            selectedTowerUIObject.GetComponent<Image>().sprite = selectedTower.gameObject.GetComponent<SpriteRenderer>().sprite;
        } else 
        {
            selectedTowerUIObject.GetComponent<Image>().sprite = noTowerSprite;
        }
    }
}
