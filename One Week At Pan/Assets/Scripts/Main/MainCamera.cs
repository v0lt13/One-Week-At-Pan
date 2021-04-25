using UnityEngine;

public class MainCamera : MonoBehaviour
{
    [Header ("Variables:")]
    public float crouchTime;
    public bool isCrouching = false;
    public static bool isMouseControls;

    [Header("Components:")]
    [HideInInspector] public Animator cameraAnimator;
    [SerializeField] private AudioClip[] cameraAudioClip;
    private CameraSystem cameraSys;
    private AudioSource cameraAudioSource;

    [Header ("GameObjects:")]
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject cameraSystem;

    void Start()
    {
        cameraAudioSource = playerCamera.GetComponent<AudioSource>();
        cameraSys = cameraSystem.GetComponent<CameraSystem>();
        cameraAnimator = playerCamera.GetComponent<Animator>();

        crouchTime = Random.Range(3, 5);
    }

    void Update()
    {
		if (crouchTime < 0)
		{
            crouchTime = 0;
		}

		if (isCrouching)
		{
            crouchTime -= Time.deltaTime;
		}

        if (Input.GetKeyDown(KeyCode.A) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.isJumpscare && !PauseMenu.isPaused && !isMouseControls)
        {
            LookLeft();
        }

        if (Input.GetKeyDown(KeyCode.D) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.isJumpscare && !PauseMenu.isPaused && !isMouseControls)
        {
            LookRight();
        }

        if (Input.GetKeyUp(KeyCode.A) && cameraSys.isCameraActive == false && cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.isJumpscare && !PauseMenu.isPaused && !isMouseControls)
        {
            CenterFromLeft();
        }

        if (Input.GetKeyUp(KeyCode.D) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.isJumpscare && !PauseMenu.isPaused && !isMouseControls)
        {
            CenterFromRight();
        }

        if (Input.GetKey(KeyCode.LeftControl) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !cameraAnimator.GetBool("isHideing") && !Main.isJumpscare && !PauseMenu.isPaused)
        {
            Crouch();
        }

        if (Input.GetKeyUp(KeyCode.LeftControl) && cameraSys.isCameraActive == false && !cameraAnimator.GetBool("isLeft") && !cameraAnimator.GetBool("isRight") && !Main.isJumpscare && !PauseMenu.isPaused)
        {
            Uncrouch();
        }
    }

    public void LookLeft()
	{
        cameraAnimator.SetBool("isLeft", true);
        cameraSys.cameraButtonOn.SetActive(false);
    }

    public void CenterFromLeft()
	{
        cameraAnimator.SetBool("isLeft", false);
        cameraSys.cameraButtonOn.SetActive(true);
    }

    public void LookRight()
    {
        cameraAnimator.SetBool("isRight", true);
        cameraSys.cameraButtonOn.SetActive(false);
    }

    public void CenterFromRight()
	{
        cameraAnimator.SetBool("isRight", false);
        cameraSys.cameraButtonOn.SetActive(true);
    }

    private void Crouch()
	{
        cameraAnimator.SetBool("isHideing", true);
        cameraSys.cameraButtonOn.SetActive(false);

        isCrouching = true;

        cameraAudioSource.clip = cameraAudioClip[0];
        cameraAudioSource.Play();
    }

    private void Uncrouch()
	{
        cameraAnimator.SetBool("isHideing", false);
        cameraSys.cameraButtonOn.SetActive(true);

        isCrouching = false;

        crouchTime = Random.Range(3, 5);

        cameraAudioSource.clip = cameraAudioClip[1];
        cameraAudioSource.Play();
    }
}
