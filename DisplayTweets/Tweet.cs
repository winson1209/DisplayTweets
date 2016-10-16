using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace DisplayTweets
{
    public class Tweet
    {
        public string AvatarSource { get; set; }
        public string TweetText { get; set; }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Tweet other = (Tweet)obj;
            return this.AvatarSource.Equals(other.AvatarSource) && this.TweetText.Equals(other.TweetText);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    

}