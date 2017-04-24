using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreTweet;
using System.Reactive.Linq;
using CoreTweet.Streaming;

namespace ShiranuiStream
{
    class Twitter : IMiniblog
    {
        private Tokens Tokens { get; }

        public Twitter() =>
            this.Tokens = Tokens.Create(
                "{API key}",
                "{API secret}",
                "{Access token}",
                "{Access token secret}");

        public async Task PostStatus(string text)
         => await this.Tokens.Statuses.UpdateAsync(status => text);

        public async Task Reply(string text, long tweetid)
         => await this.Tokens.Statuses.UpdateAsync(status => text, in_reply_to_status_id => tweetid);

        public async Task Reblog(long tweetid)
         => await this.Tokens.Statuses.RetweetAsync(id => tweetid);

        public async Task Favourite(long tweetid)
         => await this.Tokens.Favorites.CreateAsync(id => tweetid);

        public /*async*/ void StartStreaming()//実装中。以下のコードはデバッグ用
        {
            var disposable = this.Tokens.Streaming.UserAsObservable().OfType<StatusMessage>().Subscribe
                (x => Console.WriteLine("{0} Tweets {1}", x.Status.User.ScreenName, x.Status.Text));

            System.Threading.Thread.Sleep(30000);
            disposable.Dispose();
        }
    }
}
