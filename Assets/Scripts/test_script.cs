using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class test_script : MonoBehaviour
{
  public const int MAX_THROWS = 8;
  public const int MAX_ENDS = 4;

  public Rock RockA;
  public Rock RockB;

  public Camera cam;

  public Transform House;

  public UIController UI;
  public Button RestartButton;

  private Rock currentRock;
  private bool currentRockPushed = false;

  private CurlingInputActions input;

  private Rock[] endRocks;
  private (int, bool)[] endScores;

  private int currentThrow = 0;
  private int currentEnd = 0;

  public (int, int) Scores {
    get {
      return
        (
          endScores.Where(tuple => tuple.Item2).Sum(tuple => tuple.Item1),
          endScores.Where(tuple => !tuple.Item2).Sum(tuple => tuple.Item1)
        );
    }
  }

  private void Awake()
  {
    input = new CurlingInputActions();
    endRocks = new Rock[MAX_THROWS];
    endScores = new (int, bool)[MAX_ENDS];
    UI.UpdateScore(1, (0, 0));
    RestartButton.onClick.AddListener(() => {
      currentThrow = currentEnd = 0;
      UI.StartGamee();
      UI.UpdateScore(1, (0, 0));
    });
  }

  private void FixedUpdate()
  {
    if (currentEnd == MAX_ENDS) { return; }

    if (currentRock == null || (currentRockPushed && !currentRock.IsMoving)) {
      // End is over, score and reset
      if (currentThrow == MAX_THROWS) {
        var closestRocks = endRocks.Where(rock => rock != null).OrderBy(rock => Vector3.Distance(rock.transform.position, House.transform.position));
        if (closestRocks.Count() == 0) {
          endScores[currentEnd++] = (0, true);
        } else {
          bool winnerIsTeamA = closestRocks.First().IsTeamA;
          int endScore = 0;
          foreach (var rock in closestRocks) {
            if (rock.IsTeamA == winnerIsTeamA) {
              ++endScore;
            } else {
              break;
            }
          }
          endScores[currentEnd++] = (endScore, winnerIsTeamA);
        }
        clearRocks();
        UI.UpdateScore(currentEnd + 1, Scores);
        currentThrow = 0;
        if (currentEnd == MAX_ENDS) UI.EndGame();
      } else {
        currentRock = Instantiate(currentThrow % 2 == 0 ? RockA : RockB);
        endRocks[currentThrow++] = currentRock;
        currentRockPushed = false;
      }
    }

    if (currentRock != null &&
        !currentRockPushed &&
        input.Thrower.ChangeAngle.IsPressed()) {
      Vector3 currentAngle = currentRock.transform.eulerAngles;
      if (currentAngle.y > 16f) { currentAngle.y -= 360f; }
      currentAngle.y = Mathf.Clamp(currentAngle.y + input.Thrower.ChangeAngle.ReadValue<float>(), -5f, 5f);
      currentRock.transform.eulerAngles = currentAngle;
    }
  }

  private void Update()
  {
    if (currentRock == null || currentEnd == MAX_ENDS) return;
    followRock();

    if (!currentRockPushed) {
      if (input.Thrower.Throw.WasPerformedThisFrame()) {
        currentRock.StartPush();
      } else if (input.Thrower.Throw.WasReleasedThisFrame()) {
        StartCoroutine(callback_applyForce());
      }
    } else {
      if (input.Thrower.ChangeSpin.WasPerformedThisFrame()) {
        currentRock.AddToRotation((int)input.Thrower.ChangeSpin.ReadValue<float>());
      }
    }    
  }

  private void clearRocks()
  {
    foreach (var rock in endRocks) {
      if (rock != null) {
        Destroy(rock.gameObject);
      }
    }
  }

  private IEnumerator callback_applyForce()
  {
    currentRock.ReleasePush();
    yield return new WaitForFixedUpdate();
    yield return new WaitForFixedUpdate();
    yield return new WaitForFixedUpdate();
    currentRockPushed = true;
  }

  private void followRock()
  {
    cam.transform.position = currentRock.transform.position + new Vector3(0f, 1f, -3f);
    cam.transform.LookAt(currentRock.transform.position + Vector3.up);
  }

  private void OnEnable()
  {
    input.Thrower.Enable();
  }

  private void OnDisable()
  {
    input.Thrower.Disable();
  }
}
