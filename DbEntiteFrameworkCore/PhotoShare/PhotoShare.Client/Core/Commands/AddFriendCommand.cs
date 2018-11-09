namespace PhotoShare.Client.Core.Commands
{
    using Microsoft.EntityFrameworkCore;
    using PhotoShare.Data;
    using PhotoShare.Models;
    using System;
    using System.Linq;

    public class AddFriendCommand
    {
        // AddFriend <username1> <username2>
        public static string Execute(string[] data)
        {
            string requestingUsername = data[1];
            string addedFriendUsername = data[2];

            using (var context = new PhotoShareContext())
            {
                var requestingUser = context.Users.Include(u => u.FriendsAdded)
                    .ThenInclude(fa => fa.Friend).FirstOrDefault(u => u.Username == requestingUsername);

                if (requestingUser == null)
                {
                    throw new ArgumentException($"{requestingUsername} not found!");
                }

                var addedFriend = context.Users.Include( u => u.FriendsAdded)
                    .ThenInclude(fa => fa.Friend)
                    .FirstOrDefault(u => u.Username == addedFriendUsername);

                if (addedFriend == null)
                {
                    throw new ArgumentException($"{addedFriendUsername} not found!");
                }

                bool alreadyAdded = requestingUser.FriendsAdded.Any(u => u.Friend == addedFriend);
                bool accepted = addedFriend.FriendsAdded.Any(u => u.Friend == requestingUser);

                if (alreadyAdded && !accepted)
                {
                    throw new InvalidOperationException("Friend request already send!");
                }

                if (alreadyAdded && accepted)
                {
                    throw new InvalidOperationException($"{addedFriendUsername} is already a friend to {requestingUsername}");
                }

                if (!alreadyAdded && accepted)
                {
                    throw new InvalidOperationException($"{requestingUsername} has already received a friend request from {addedFriendUsername}");
                }

                requestingUser.FriendsAdded.Add(new Friendship()
                {
                    User = requestingUser,
                    Friend = addedFriend
                });

                context.SaveChanges();
                return $"Friend {addedFriendUsername} added to {requestingUsername}";
            }
        }
    }
}
