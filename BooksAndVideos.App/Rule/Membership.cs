using System;
using System.Collections.Generic;
using System.Text;
using BooksAndVideos.App.Entities;

namespace BooksAndVideos.App.Rule
{
    public class MembershipRule : IRule
    {
        private Entity _item;

        public MembershipRule(Entity item)
        {
            _item = item;
        }

        public void CompleteRule()
        {
            ActivateMembership();
        }

        private void ActivateMembership()
        {
            // Activates the customers membership
        }
    }
}
