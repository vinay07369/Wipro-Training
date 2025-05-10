using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SocialMedia
    {
        public virtual void Post()
        {
            Console.WriteLine("Posting on Social Media...");   
        }
    }

    class FacebookPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting On Facebook...");
        }
    }

    class TwitterPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting On Twitter...");
        }
    }

    class InstagramPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting On Instagram...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        { 
            FacebookPost fb = new FacebookPost();

            TwitterPost tw = new TwitterPost();

            InstagramPost ig = new InstagramPost();

            fb.Post();

            tw.Post();

            ig.Post();

        }
    }
}