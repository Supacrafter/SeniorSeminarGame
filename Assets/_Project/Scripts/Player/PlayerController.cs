using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private TowerBase selectedTower; // Tower selected to place
    [SerializeField] private GameObject selectedTowerUIObject;

    private Image UIObjImage;
    private void Start()
    {
        UIObjImage = selectedTower.GetComponent<Image>();
        UpdateSelectionUI();
    }

    private void OnEnable()
    {
        InputReader.controls.Placement.PlaceTower.performed += ctx => PlaceTower(ctx, Mouse.current.position.ReadValue());
        InputReader.controls.Placement.Cancel.performed += CancelTowerPlacement;
        InputReader.controls.Placement.ToggleMode.performed += StartTowerPlacement;

        InputReader.controls.Base.ToggleMode.performed += StartTowerPlacement;
        InputReader.controls.Base.Pause.performed += PauseTest;
    }

    //private void Click(Vector2 mousePos)
    //{
    //    Debug.Log("Clicked! Position: " + mousePos);
    //    Debug.Log("WorldPos of mouse: " + mainCamera.ScreenToWorldPoint(mousePos));
    //}

    private void PlaceTower(InputAction.CallbackContext ctx, Vector2 position)
    {
        if (MoneyManager.instance.GetBalance() - selectedTower.GetCost() >= 0)
        {
            TowerBase newTower = Instantiate(selectedTower);
            Vector3 towerPosition = mainCamera.ScreenToWorldPoint(position);

            newTower.transform.position = new Vector3(towerPosition.x, towerPosition.y, 0);
            MoneyManager.instance.RemoveMoney(newTower.GetCost());
        } else
        {
            Debug.Log("ur poor lol");
        }
    }

    private void PauseTest(InputAction.CallbackContext ctx)
    {
        Debug.Log("Paused!");
    }

    private void CancelTowerPlacement(InputAction.CallbackContext ctx)
    {
        InputReader.ToggleActionMap(InputReader.controls.Base);
    }

    private void StartTowerPlacement(InputAction.CallbackContext ctx)
    {
        InputReader.ToggleActionMap(InputReader.controls.Placement);
    }

    private void PlaceTower(Vector2 position)
    {

    }

    private void OnClick(InputAction.CallbackContext ctx)
    {
        // Based on current action map, do something
    }

    private void UpdateSelectionUI()
    {
        selectedTowerUIObject.GetComponent<Image>().sprite = selectedTower.gameObject.GetComponent<SpriteRenderer>().sprite;
    }
}
