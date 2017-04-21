using System;
using System.Collections.Generic;
using System.Text;

namespace ShiranuiStream
{
    /// <summary>
    /// TwitterとMastodonの共通する機能をまとめたインターフェースです
    /// </summary>
    interface IMiniblog
    {
        /// <summary>
        /// Twitter:Tweet/Mastodon:Toot
        /// </summary>
        void Post();
        /// <summary>
        /// Twitter:ReTweet/Mastodon:Boost
        /// </summary>
        void Reblog();
        /// <summary>
        /// Twitter:Reply/Mastodon:Reply
        /// </summary>
        void Reply();
        /// <summary>
        /// Twitter:Favorite/Mastodon:Favourite
        /// </summary>
        void Favourite();
    }
}
