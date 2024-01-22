namespace Messenger.Models
{
    public class Message
    {
        public Message()
        {
            When = DateTime.Now;
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string text {  get; set; }
        public DateTime When { get; set;}
        public string UserId {  get; set; }
        public virtual AppUser Sender { get; set; }
    }
}
