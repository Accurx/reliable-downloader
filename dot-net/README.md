### .NET README

There is already a ```IWebSystemCalls.cs``` and corresponding implementation which allows you to get the HTTP headers for a URL, download the whole content, or download partial content. All these calls return an ```HttpResponseMessage``` object which contains properties for headers and the content.

As in the example here: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept-Ranges, the HTTP header "Accept Ranges" will be set to "Bytes" if the CDN supports partial content.

An NUnit test project is included - feel free to swap out NUnit for any other test framework you may prefer. There is also a Program Main function which has a real Accurx URL (which **DOES** support partial content) and an example of a file path so that the code can be tested for real.
