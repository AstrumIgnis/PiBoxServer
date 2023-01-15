namespace PiBox_Server.Sync
{
    public class Messenger
    {
        public Action OnMessage { get; set; }
        public string Text { get; set; }

        public void AddMessage(string message) {
            Text = message;
            OnMessage.Invoke();
        }

    }
}