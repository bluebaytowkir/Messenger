using Microsoft.AspNetCore.Identity;

namespace Messenger.Models
{
    public class AppUser:IdentityUser
    {
        public AppUser() 
        {
            Messages=new HashSet<Message>();
        }

        //1 - * AppUser || Message
        public virtual ICollection<Message> Messages { get; set; }

    }
}
