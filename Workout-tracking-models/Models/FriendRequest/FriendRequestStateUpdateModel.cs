using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracking.Application.Models.FriendRequest
{
    public class FriendRequestStateUpdateModel
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string State { get; set; }
    }
}
