# Reliable Downloader Exercise

## About

The purpose of this exercise is to get an understanding of how you analyse requirements, solve problems, use language features appropriately, structure code and verify your solution works correctly.

See our [Product Engineer Interview Process page](https://www.notion.so/accurx/Product-Engineer-Interview-Process-440518330d144db2bb51f8bc16bdc5c0) for more tips.

## Task

The task here is to implement a reliable File Downloader ```FileDownloader.cs```.

There is only one main call:

```Task<bool> DownloadFile(string contentFileUrl, string localFilePath, Action<FileProgress> onProgressChanged)```

Sadly, there are many reasons why just calling GET on a file won't work happily. The user's internet may drop or their internet speed might be awful and we will struggle to get a 10Mb file down in one go. Luckily, some CDNs support downloading partial content so if we can get 50% of the way through, we can resume from this point. Your solution needs to be resilient to failures and should not exit until the file has been successfully downloaded. You will need to verify your solution works correctly, you might like to include notes on how you approached this in your submission.   

There is already a ```IWebSystemCalls.cs``` and corresponding implementation which allows you to get the http headers for a URL, download the whole content or download the partial content. All these calls return ```HttpResponseMessage``` which contains sub properties for headers and the content to be read as a string/stream etc.

As in the example here: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept-Ranges, the http header "Accept Ranges" will be set to "Bytes" if the CDN supports partial content.

The task is as follows:

1. Implement a reliable file downloader. If the URL does NOT support partial content then we attempt to just download the whole file (perhaps we can still consider how to make this more "reliable"). However, in the happy path that we do support partial content, we can attempt a more reliable download where we download in smaller chunks and can resume post any internet drop without needing to repeat sections that have already been downloaded and without exiting.
2. We may want to check the integrity of the file after downloading. We can use the Content-MD5 https://www.oreilly.com/library/view/http-the-definitive/1565925092/re17.html for this.
3. We want to report some basic progress to the user during this process.

Extensions

1. Add some basic time remaining - if we've downloaded 50% in 1 minute we should suggest roughly 1 minute left
2. Add cancellation so the user can stop any in progress downloads

A test project is included (with Nunit added though can be swapped for XUnit) if Unit tests are wanted. There is also a Program Main function which has a real accuRx url (which DOES support partial content) and an example of a file path so that the code can be tested for real.

Tips

- You can throttle your internet connection using NetLimiter or similar
