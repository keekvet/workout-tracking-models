using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTracking.Application.Dto.User
{
    public class FriendRequestDto
    {
        public int Id { get; set; }
        public int RequestFromId { get; set; }
        public int RequestToId { get; set; }
        public string State{ get; set; }
    }
}
