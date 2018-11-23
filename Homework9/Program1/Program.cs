using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;

namespace Program1
{
    class Program
    {
        public class Crawler
        {
            private Queue<String> urls = new Queue<string>();
            private int count = 0;
            private string html;

            public Crawler(string url)
            {
                html = "";
                if (url.Length > 0)
                {
                    urls.Enqueue(url);
                }
            }

            public void Crawl()
            {
                Console.WriteLine("开始爬行了……");
                while (true)
                {
                    if (urls.Count == 0)
                    {
                        continue;
                    }
                    string current = urls.Peek();
                    if (current == null || count > 50)
                    {
                        break;
                    }
                    Console.WriteLine("爬行" + current + "页面");
                    DownLoad(current);
                    //Parse();
                    Thread thread = new Thread(Parse);
                    thread.Start();
                }
                Console.WriteLine("爬行结束");
            }

            private void Parse()
            {
                lock (html)
                {
                    string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#(img)]+[""']";
                    MatchCollection matches = new Regex(strRef).Matches(html);
                    foreach (Match match in matches)
                    {
                        strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\\', '#', ' ', '>');
                        if (strRef.Length == 0)
                        {
                            continue;
                        }
                        urls.Enqueue(strRef);
                    }              
                }
            }

            public void DownLoad(String url)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = Encoding.UTF8;
                    string content = webClient.DownloadString(url);
                    string fileName = count.ToString();
                    urls.Dequeue();
                    count++;
                    File.WriteAllText(fileName + ".html", content, Encoding.UTF8);
                    lock (html)
                    {
                        html = content;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    urls.Dequeue();
                }
            }
        }
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            Crawler c = new Crawler("https://www.hao123.com/");
            c.Crawl();
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            Console.WriteLine(timeSpan.ToString());
        }
    }
}
