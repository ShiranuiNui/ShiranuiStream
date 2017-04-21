using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        Task PostStatus(string Text);
        /// <summary>
        /// Twitter:ReTweet/Mastodon:Boost
        /// </summary>
        Task Reblog(long id);
        /// <summary>
        /// Twitter:Reply/Mastodon:Reply
        /// </summary>
        Task Reply(string Text,long id);
        /// <summary>
        /// Twitter:Favorite/Mastodon:Favourite
        /// </summary>
        Task Favourite(long id);
        void StartStreaming();
    }
}
