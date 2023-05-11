using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using UnityEngine.SceneManagement;


public class ControlTiempo : MonoBehaviour, MMEventListener<MMGameEvent>
{
    bool timerOn = false;
    private float timeDuration = 3f *60f;
    private float timer;
    [SerializeField]
    private TextMeshProUGUI firstMinute;
    [SerializeField]
    private TextMeshProUGUI secondMinute;
    [SerializeField]
    private TextMeshProUGUI separator;
    [SerializeField]
    private TextMeshProUGUI firstSecond;
    [SerializeField]
    private TextMeshProUGUI secondSecond;
    [SerializeField]

    public static ControlTiempo inst;
    // Start is called before the first frame update
    void Awake()
    {
        if (ControlTiempo.inst == null)
        {
            ControlTiempo.inst = this;
            DontDestroyOnLoad(gameObject);

        } else {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        if (timerOn == false )
        {
            ResetTimer();
        }

    }

    void Update()
    {
        //if(estado)
        if (timer > 0 ) {
            timer -= Time.deltaTime;
            UpdateTimerDisplay(timer);
        } else {
            flash();
        }
        //Debug.Log(timer);
    }

    private void ResetTimer() {
        timer = timeDuration;
        timerOn = true;
    }

    public void SetUIControls(ControlTiempoManager ctm){
        firstMinute=ctm.T1; 
        secondMinute = ctm.T2;
        firstSecond = ctm.T3;
        secondSecond = ctm.T4;
        //Reanudar tiempo
    }

    void OnEnable()
    {
        this.MMEventStartListening<MMGameEvent>();
    }
    void OnDisable()
    {
        this.MMEventStopListening<MMGameEvent>();
    }

    public virtual void OnMMEvent(MMGameEvent e)
    {
       if(e.EventName=="TiempoEvent")
       {
        SetUIControls(ControlTiempoManager.Instance);
       }

       if(e.EventName=="LoadingTiempoEvent")
       {
        //Detener tiempo por estado
       }
    }

    private void UpdateTimerDisplay (float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        string currentTime = string.Format("{00:00}{1:00}", minutes, seconds);
        firstMinute.text = currentTime[0].ToString(); 
        secondMinute.text = currentTime[1].ToString();
        firstSecond.text = currentTime[2].ToString();
        secondSecond.text = currentTime[3].ToString();
    }   

    private void flash ()
    {
        if(timer != 0){
            timer = 0;
            UpdateTimerDisplay(timer);
        }
        SceneManager.LoadScene("Game_Over");
    }
}
