using UnityEngine;

public class Example : MonoBehaviour
{
    public string message;
    public float sendDuration;
    public float waitDuration;
    private bool canSend;
    private float timer;

    void Start()
    {
        timer = 0;
    }
    
    void Update()
    {
        if (canSend)
        {
            SendMessage();
            if (timer >= sendDuration)
            {
                canSend = false;
                timer = 0;
            }
        }
        else
        {
            if (timer >= waitDuration)
            {
                canSend = true;
                timer = 0;
            }
        }
        timer += Time.deltaTime;
    }

    void SendMessage()
    {
        print(this.message);
    }

}
