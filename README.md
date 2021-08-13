# 👩‍⚕️ Reliable Downloader Exercise 🖥️

Thank you for investing your time in our take home exercise.

We've based this exercise on a real problem we've had to solve in order to be able to release our [desktop software](https://www.youtube.com/channel/UCrLJDyngP4p0G0JtgEoT66Q/videos), which allows clinicians to communicate with patients over text, video, questionnaires and do a whole bunch more besides!, to many hundreds of thousands of users multiple times a week.

We hope you enjoy it and find it relevant.

Stumbled upon this repo? [Find out more about accuRx](https://www.accurx.com/careers)

The purpose of this exercise is for us to learn about how you analyse requirements, solve problems, use language features appropriately, structure code and verify your solution works correctly. These are the main factors we take into account when assessing your solution.

Feel free to spend as much or as little on the exercise as you like, we recommend 2-3 hours. Just let us know in your answers how much time you had available and what you would do with more time, we'll take that into account when assessing your solution.

Please answer the following questions in `questions.md`.

- How did you approach solving the problem?
- How did you verify your solution works correctly?
- How long did you spend on the exercise?
- What would you add if you had more time and how?

When you're finished, please share your solution by inviting us to a private repository (accurx-ravi, BIOsborne, CalumJEadie, JafarMiles-AccuRx, lbargery, mattlowe1 and max-jacobs) containing your solution and using the link in your invite email to submit a link to the repository.

Thanks for your time, we hope you enjoy the exercise and please do get in touch if you have any questions!

## Task

To release software to many hundreds of thousands of clinicians multiple times a week, our component for downloading updates needs to be reliable in the challenging networking conditions clinicians can face: intermittent internet disconnection and slow internet speeds.

Your core task is to extend the skeleton project to meet the following requirements:

- Performing a normal GET on a file won't be reliable for two reasons. Firstly, we need to be able to recover from internet disconnections. Secondly, we need to not have to start from scratch every time, with intermittent internet disconnection and slow internet, it's unlikely we'll be able to download the whole file in one go.

- Luckily, some CDNs support downloading partial content so if we can get part of the way through, we can resume from this point.

- If the URL does not support partial content then we attempt to just download the whole file.

- Clinicians need to eventually receive new updates as they're sent out, even if it takes many attempts due to their internet connection. Your solution needs to recover from failures and should not exit until the file has been successfully downloaded.

We are looking for you to demonstrate:

- Analysing requirements
- Solving problems
- Using language features appropriately
- Structuring code
- Verifying your solution works correctly

There is already a ```IWebSystemCalls.cs``` and corresponding implementation which allows you to get the http headers for a URL, download the whole content or download the partial content. All these calls return ```HttpResponseMessage``` which contains sub properties for headers and the content to be read as a string/stream etc.

As in the example here: https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept-Ranges, the http header "Accept Ranges" will be set to "Bytes" if the CDN supports partial content.

A test project is included (with Nunit added though can be swapped for XUnit) if Unit tests are wanted. There is also a Program Main function which has a real accuRx url (which DOES support partial content) and an example of a file path so that the code can be tested for real.

Optional extension tasks are:

- Checking the integrity of the file after downloading. We can use the Content-MD5 https://www.oreilly.com/library/view/http-the-definitive/1565925092/re17.html for this.
- Reporting progress to the user during this process.
- Reporting time remaining - if we've downloaded 50% in 1 minute we should suggest roughly 1 minute left
- Adding cancellation so the user can stop any in progress downloads.

## Tips

- Take time to read through the question and description. There's guidance in there that can be helpful to approaching the problem.
- The code doesn't need to be beautiful but it needs to be readable.
- Try writing down some example input and outputs on paper.
- Try a brute force approach and then optimise the code.
- Add some comments to your code if you think it will be helpful to share your thought process to someone assessing it.
- You can throttle your internet connection using NetLimiter or similar.
- You can simulate internet disconnections through disconnecting wifi/ethernet.
- Different behaviours occur after following different periods of disconnection, two seconds and two minutes are sweet spots for exercising key failure modes.